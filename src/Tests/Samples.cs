﻿using System;
using System.IO;
using System.Threading.Tasks;
using Aspose.Pdf.Devices;
using Verify;
using VerifyXunit;
using Xunit;
using Xunit.Abstractions;

#region TestDefinition
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
    #endregion

    #region VerifyPdf

    [Fact]
    public Task VerifyPdf()
    {
        return VerifyFile("sample.pdf");
    }

    #endregion

    [Fact]
    public Task VerifyPdfResolution()
    {
        var resolution = new Resolution(100);
        var settings = new VerifySettings();
        settings.PdfPngDevice(page =>
        {
            var artBox = page.ArtBox;
            var width = Convert.ToInt32(artBox.Width);
            var height = Convert.ToInt32(artBox.Height);
            return new PngDevice(width, height, resolution);
        });
        return VerifyFile("sample.pdf", settings);
    }

    #region VerifyPdfStream

    [Fact]
    public Task VerifyPdfStream()
    {
        var settings = new VerifySettings();
        settings.UseExtension("pdf");
        return Verify(File.OpenRead("sample.pdf"), settings);
    }

    #endregion

#if DEBUG

    #region VerifyPowerPoint

    [Fact]
    public Task VerifyPowerPoint()
    {
        return VerifyFile("sample.pptx");
    }

    #endregion

    #region VerifyPowerPointStream

    [Fact]
    public Task VerifyPowerPointStream()
    {
        var settings = new VerifySettings();
        settings.UseExtension("pptx");
        return Verify(File.OpenRead("sample.pptx"), settings);
    }

    #endregion

#endif

    #region VerifyExcel

    [Fact]
    public Task VerifyExcel()
    {
        return VerifyFile("sample.xlsx");
    }

    #endregion

    #region VerifyExcelStream

    [Fact]
    public Task VerifyExcelStream()
    {
        var settings = new VerifySettings();
        settings.UseExtension("xlsx");
        return Verify(File.OpenRead("sample.xlsx"), settings);
    }

    #endregion

    #region VerifyWord

    [Fact]
    public Task VerifyWord()
    {
        return VerifyFile("sample.docx");
    }

    #endregion

    #region VerifyWordStream

    [Fact]
    public Task VerifyWordStream()
    {
        var settings = new VerifySettings();
        settings.UseExtension("docx");
        return Verify(File.OpenRead("sample.docx"), settings);
    }

    #endregion
}