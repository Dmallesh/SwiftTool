# MT101 Swift message parser and validator

## Introduction
Your current task is to implement a parser and a validator for data that contains Swift MT101 messages.

The MT standards have a specific structure (described below).
The MT messages are divided into many categories from various financial areas. Each category has a specific message type.
The SWIFT MT101 message is a request for transfer, enabling the electronic transfer of funds from one account to another.

## MT 101 Format Specifications
**Notice: For the current task, the Swift MT101 message specification described below is limited only to the required range.**

### Blocks specification
All swift messages have a block structure (5 blocks) and each block starts and ends with a curly bracket:
**{1:data}{2:data}{3:data}{4:data}{5:data}**
**Blocks 1, 2, 3 and 5** are out of scope for this task and should be ignored. 
**Block 4** is required and at least one block 4 has to exist. 
**Block 4** always starts with `{4:` and ends with `-}`. 
**Block 4** contains **tags** (ex: `:21:`):
	- **Tag** starts and ends with `:` (for example `:71A:SHA` - tag 71A has value `SHA`). 
	- **Tag** always starts with a new line.
**Block 4** consists of two sequences:
	- **Sequence A**: Single occurrence mandatory sequence. It contains information to be applied to all individual transactions detailed in sequence B.
	- **Sequence B**: Each sequence B starts with tag `:21:`. Each occurrence provides details of only one individual transaction.

**Sample of the MT 101:**
*"Sequence A", "Sequence B (first transaction)", "Sequence B (second transaction)" are not present in the messages - these are just comments*

**{1:** SOMETHING **}{2:** SOMETHING **}{3:**{113:SEPA}{108:SOMETHING}}**{4:**
***Sequence A***
:20:1106210100000003 
:28D:1/2 
:50H:/PL64114010100000123456001001
ORDERING CUSTOMER NAME1
ORDERING CUSTOMER NAME2
STREET
CITY
:52A:BREXPLPWXXX
:30:110621 
***Sequence B (first transaction)***
`:21:`2011062100000003 
:32B:EUR955,55 
:57A:CITIGB2LXXX 
:59:/IT40S0542811101000000123456
BENEFICIARY NAME 1
BENEFICIARY NAME 2
STREET
CITY
:70:INVOICE 11/06/06 
:71A:SHA 
***Sequence B (second transaction)***
`:21:`2011062100000003 
:32B:EUR100,12 
:57A:CITIGB2LXXX 
:59:/IT40S054281110100000098765
BENEFICIARY ABC NAME 1
BENEFICIARY ABC NAME 2
STREET 2
CITY 2
:70:INVOICE 12/06/06 
:71A:SHA 
**-}{5:**{MAC:00000000}{CHK:24857F4599E7}{TNG:}**}**

### SWIFT Characters Set
Letters and numbers: `a-z, A-Z, 0-9`
Characters: `/-?:().,'+{}`
CR: `0x0D`
LF: `0x0A`
Space: `0x20`

### Types
`n` - Digits only `0-9`,
`a` - Alphabetic letters `A-Z` (uppercase),
`c` - Capital letters and decimal numbers respectively `A-Z0-9`,
`x` - Any character of `a-zA-Z0-9`,
`d` - Decimal number (comma as separator, ex: `99999,99`),
`!` - fixed length,
`[nn]` - optional (not required),
`nn*nn` - maximum number of lines times maximum line length; lines separated by CRLF.

Examples: 
`6!n` - always 6 digits, 
`3!a15d` - always 3 letters (uppercase) and next decimal number (maximum 15 characters including separator).
`/34x[4*35x]` - first line contains 35 characters and always starts with `/`; next up to 4 lines (if exists) consisting of up to 35 characters; lines separated by CRLF,
`[/34x]4*35x` - first line if exists contains 35 characters and always starts with `/`; next up to 4 lines (if exists) consisting of up to 35 characters; lines separated by CRLF,

### Tags in Sequence A and B
**Other tags not specified below should be ignored.**

**Sequence A**
|Tag|Field name|Type|Validation rules|
|--|--|--|--|
|:20:|Sender's Reference|`16x`|Mandatory and not empty|
|:50H:|Ordering Customer|`/34x[4*35x]`|Mandatory. Value starts with `/` and next 34x contains account number. Account is required. Next lines if exist contains the Name and the Address of the Ordering Customer. Empty lines should be ignored.|
|:30:|Requested Execution Date|`6!n`|Mandatory. Date has to have the following format: YYMMDD (year,  month, day)|

**Sequence B**
|Tag|Field name|Type|Validation rules|
|--|--|--|--|
|21|Transaction Reference|`16x`|Mandatory and not empty|
|32B|Currency/Transaction Amount|`3!a15d`|Mandatory. Contains the currency code and amount. Amount should be a correct decimal value and must be greater than 0|
|59|Beneficiary|`[/34x]4*35x`|Mandatory. At least one not empty line is required (account or name and address). If line 1 starts with `/` it contains account number. Lines 2-5 (or 1-4 if account not exists) contain the beneficiary’s name and address. Empty lines should be ignored.|
|70|Remittance Information|`4*35x`|Not mandatory. If exists, it contain transaction details. Empty lines should be ignored.|

## Requirements

**Remember:**
**The content is UTF-8 encoded.**
**The line separator is CRLF.**

The `MT101Parser.ValidateFormat` method should check (in the order described below) if:
- **Attention: line numbers returned in exceptions should be counted from 1 (not from 0)**
- The content contains any characters, otherwise the `NoDataException` should be thrown.
- There are no empty lines, otherwise you should throw `EmptyLinesException` containing invalid line numbers.
- There are no lines starting with `-`, except for `-}`; otherwise you should throw `IncorrectLinesException` containing invalid line numbers.
- There is at least one block `{4:`; otherwise the `MTFormatException` should be thrown.
- No other curly brackets (`{`,`}`) exist inside Block `{4:...-}`; otherwise the `MTFormatException` should be thrown.
- All lines contain only the allowed characters (see the **SWIFT characters set**), otherwise the `NotAllowedCharactersException` with a list with the forbidden characters and their position in the file (counted from 1) should be thrown. 
	
**We can assume that the data format is correct (`ValidateFormat` was executed before calling `Parse`).**	
The `MT101Parser.Parse` should:
- Only parse blocks 4 (other blocks should be ignored).
- Remember that not all fields in block 4 are mandatory.
- Only tags specified in **Tags in Sequence A and B** should be read to `SwiftTools.Model.MT101Message`; others should be ignored.
- Based on the **Tags in Sequence A and B** (*Type* and *Validation rules* columns):
	- If tag value is incorrect the information about the incorrect tag should be added to the `SwiftTools.Model.MT101Message.Errors`.
	- Incorrect value should be not set into `SwiftTools.Model.MT101Message` properties.
	- If tag is mandatory but not exists the information about the mandatory tag should be added to the `SwiftTools.Model.MT101Message.Errors`.	
- The `Model.MT101Message.Raw` should contain the whole data of block 4 from the original file (`{4:...-}`).

The functionality should be exposed as a RESTfull service:
- The `SwiftToolsApiController.ValidateMT101Content` should be available as a HTTP POST `/api/swift/validate-format-mt101`. 
	It should use `ValidateFormat` to validate the content.
	It should return the value according to the function description in the code.
- The `SwiftToolsApiController.ParseMT101Content` should be available as a HTTP POST `/api/swift/parse-mt101`. 
	It should use the `SwiftParser.MT101Parser` to parse the Swift messages.
	The function should return the `ParsingResult` which contains parsed messages.

## Hints
1. Your solution should pass all tests.
2. Follow the TODO comments.
3. *To run all tests, you may need to run Visual Studio with administrator privileges.*
