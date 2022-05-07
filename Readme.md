Line Condenser - My first c# project

A simple WPF gui app - Has a Textbox field to paste in an input string and will condense the values onto a single line,
adding in a left and right delimiter to each entry, an entry separator, as well as characters on the start and end of the final string.
Output text will update as values for the inputs and separator characters are updated.
Output can be copied to clipboard on button click.

Example use case is for pasting in a list of values (eg from a spreadsheet) which you want to enclose in quotes and separate by commas,
EG so that it can be entered in a SQL statement such as WHERE x IN ('foo','bar','baz').
Default values are applied for this use case but can be amended as required.