// See https://aka.ms/new-console-template for more information
using Spectre.Console;

// Create the layout
var layout = new Layout("Root")
    .SplitColumns(
        new Layout("Left"),
        new Layout("Right")
            .SplitRows(
                new Layout("Top"),
                new Layout("Bottom")));

// Update the left column
layout["Left"].Update(
    new Panel(
        Align.Center(
            new Markup("[blue]Welcome to Frostshoxx Terminal![/]"),
            VerticalAlignment.Middle))
        .Expand());

// Update the top right column
layout["Top"].Update(
    new Panel(
        Align.Center(
            new Markup("[blue]Stock Market Tracker[/]"),
            VerticalAlignment.Middle))
        .Expand());

layout["Bottom"].Update(
    new Panel(
        Align.Center(
            new Markup("[blue]Crypto Tracker[/]"),
            VerticalAlignment.Middle))
        .Expand());

// Render the layout
AnsiConsole.Write(layout);
Console.ReadLine();
