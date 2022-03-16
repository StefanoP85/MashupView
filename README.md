# MashupView
Extract the query definitions from Excel files, created with Power Query.

This simple App extracts the query definitions from Excel files, and exposes the Mashup language, as known as "M language".
Thanks to .NET's System.IO.Packaging.Package class, it's very easy to read the Open XML files, and the queries included.
The files is based on the [MS-QDEFF].pdf from Microsoft, the "Query Definition File Format".
