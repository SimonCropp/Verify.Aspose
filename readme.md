<!--
GENERATED FILE - DO NOT EDIT
This file was generated by [MarkdownSnippets](https://github.com/SimonCropp/MarkdownSnippets).
Source File: /readme.source.md
To change this file edit the source file and then run MarkdownSnippets.
-->

# <img src="/src/icon.png" height="30px"> Verify.Aspose

[![Build status](https://ci.appveyor.com/api/projects/status/7k8hh0guut2ioak2?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-Aspose)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Aspose.svg)](https://www.nuget.org/packages/Verify.Aspose/)

Extends [Verify](https://github.com/SimonCropp/Verify) to allow verification of documents via [Aspose](https://www.aspose.com/).

Converts documents (pdf, docx, xslx, and pptx) to png for verification.

An [Aspose License](https://purchase.aspose.com/policies/license-types) is required to use this tool.

<!-- toc -->
## Contents

  * [Usage](#usage)
    * [PDF](#pdf)
    * [Excel](#excel)
    * [Word](#word)
    * [PowerPoint](#powerpoint)
  * [File Samples](#file-samples)<!-- endtoc -->


## NuGet Package

https://nuget.org/packages/Verify.Aspose/


## Usage

Given a test with the following definition:

<!-- snippet: TestDefinition -->
<a id='snippet-testdefinition'/></a>
```cs
public class Samples :
    VerifyBase
{
    public Samples(ITestOutputHelper output) :
        base(output)
    {
    }

    static Samples()
    {
        VerifyAspose.Initialize();
    }
```
<sup><a href='/src/Tests/Samples.cs#L8-L21' title='File snippet `testdefinition` was extracted from'>snippet source</a> | <a href='#snippet-testdefinition' title='Navigate to start of snippet `testdefinition`'>anchor</a></sup>
<!-- endsnippet -->


### PDF


#### Verify a file

<!-- snippet: VerifyPdf -->
<a id='snippet-verifypdf'/></a>
```cs
[Fact]
public Task VerifyPdf()
{
    return VerifyFile("sample.pdf");
}
```
<sup><a href='/src/Tests/Samples.cs#L23-L31' title='File snippet `verifypdf` was extracted from'>snippet source</a> | <a href='#snippet-verifypdf' title='Navigate to start of snippet `verifypdf`'>anchor</a></sup>
<!-- endsnippet -->


#### Verify a Stream

<!-- snippet: VerifyPdfStream -->
<a id='snippet-verifypdfstream'/></a>
```cs
[Fact]
public Task VerifyPdfStream()
{
    var settings = new VerifySettings();
    settings.UseExtension("pdf");
    return Verify(File.OpenRead("sample.pdf"), settings);
}
```
<sup><a href='/src/Tests/Samples.cs#L33-L43' title='File snippet `verifypdfstream` was extracted from'>snippet source</a> | <a href='#snippet-verifypdfstream' title='Navigate to start of snippet `verifypdfstream`'>anchor</a></sup>
<!-- endsnippet -->


#### Result

[Samples.VerifyPdf.00.verified.png](/src/Tests/Samples.VerifyPdf.00.verified.png):

<img src="/src/Tests/Samples.VerifyPdf.00.verified.png" width="200px">


### Excel


#### Verify a file

<!-- snippet: VerifyExcel -->
<a id='snippet-verifyexcel'/></a>
```cs
[Fact]
public Task VerifyExcel()
{
    return Verify("sample.xlsx");
}
```
<sup><a href='/src/Tests/Samples.cs#L71-L79' title='File snippet `verifyexcel` was extracted from'>snippet source</a> | <a href='#snippet-verifyexcel' title='Navigate to start of snippet `verifyexcel`'>anchor</a></sup>
<!-- endsnippet -->


#### Verify a Stream

<!-- snippet: VerifyExcelStream -->
<a id='snippet-verifyexcelstream'/></a>
```cs
[Fact]
public Task VerifyExcelStream()
{
    var settings = new VerifySettings();
    settings.UseExtension("xlsx");
    return Verify(File.OpenRead("sample.xlsx"), settings);
}
```
<sup><a href='/src/Tests/Samples.cs#L81-L91' title='File snippet `verifyexcelstream` was extracted from'>snippet source</a> | <a href='#snippet-verifyexcelstream' title='Navigate to start of snippet `verifyexcelstream`'>anchor</a></sup>
<!-- endsnippet -->


#### Result

[Samples.VerifyExcel.00.verified.png](/src/Tests/Samples.VerifyExcel.00.verified.png):

<img src="/src/Tests/Samples.VerifyExcel.00.verified.png" width="200px">


### Word


#### Verify a file

<!-- snippet: VerifyWord -->
<a id='snippet-verifyword'/></a>
```cs
[Fact]
public Task VerifyWord()
{
    return Verify("sample.docx");
}
```
<sup><a href='/src/Tests/Samples.cs#L93-L101' title='File snippet `verifyword` was extracted from'>snippet source</a> | <a href='#snippet-verifyword' title='Navigate to start of snippet `verifyword`'>anchor</a></sup>
<!-- endsnippet -->


#### Verify a Stream

<!-- snippet: VerifyWordStream -->
<a id='snippet-verifywordstream'/></a>
```cs
[Fact]
public Task VerifyWordStream()
{
    var settings = new VerifySettings();
    settings.UseExtension("docx");
    return Verify(File.OpenRead("sample.docx"), settings);
}
```
<sup><a href='/src/Tests/Samples.cs#L103-L113' title='File snippet `verifywordstream` was extracted from'>snippet source</a> | <a href='#snippet-verifywordstream' title='Navigate to start of snippet `verifywordstream`'>anchor</a></sup>
<!-- endsnippet -->


#### Result

[Samples.VerifyWord.00.verified.png](/src/Tests/Samples.VerifyWord.00.verified.png):

<img src="/src/Tests/Samples.VerifyWord.00.verified.png" width="200px">


### PowerPoint


#### Verify a file

<!-- snippet: VerifyPowerPoint -->
<a id='snippet-verifypowerpoint'/></a>
```cs
[Fact]
public Task VerifyPowerPoint()
{
    return VerifyFile("sample.pptx");
}
```
<sup><a href='/src/Tests/Samples.cs#L47-L55' title='File snippet `verifypowerpoint` was extracted from'>snippet source</a> | <a href='#snippet-verifypowerpoint' title='Navigate to start of snippet `verifypowerpoint`'>anchor</a></sup>
<!-- endsnippet -->


#### Verify a Stream

<!-- snippet: VerifyPowerPointStream -->
<a id='snippet-verifypowerpointstream'/></a>
```cs
[Fact]
public Task VerifyPowerPointStream()
{
    var settings = new VerifySettings();
    settings.UseExtension("pptx");
    return Verify(File.OpenRead("sample.pptx"), settings);
}
```
<sup><a href='/src/Tests/Samples.cs#L57-L67' title='File snippet `verifypowerpointstream` was extracted from'>snippet source</a> | <a href='#snippet-verifypowerpointstream' title='Navigate to start of snippet `verifypowerpointstream`'>anchor</a></sup>
<!-- endsnippet -->


#### Result

[Samples.VerifyPowerPoint.00.verified.svg](/src/Tests/Samples.VerifyPowerPoint.00.verified.svg):


## File Samples

http://file-examples.com/


## Release Notes

See [closed milestones](../../milestones?state=closed).


## Icon

[Swirl](https://thenounproject.com/term/swirl/1568686/) designed by [creativepriyanka](https://thenounproject.com/creativepriyanka) from [The Noun Project](https://thenounproject.com/creativepriyanka).
