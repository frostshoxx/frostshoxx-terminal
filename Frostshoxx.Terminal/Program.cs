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
            VerticalAlignment.Top))
        .Expand());

// Update the top right column
layout["Top"].Update(
    new Panel(
        Align.Center(
            new Markup("[blue]Stock Market Tracker[/]"),
            VerticalAlignment.Top))
        .Expand());

layout["Bottom"].Update(
    new Panel(
        Align.Center(
            new Markup("[blue]Crypto Tracker[/]"),
            VerticalAlignment.Top))
        .Expand());

// Render the layout
AnsiConsole.Write(layout);

// Ask for the user's favorite fruit
var fruit = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("What's your [green]favorite fruit[/]?")
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
        .AddChoices([
            "Apple",
            "Apricot",
            "Avocado",
            "Banana",
            "Blackcurrant",
            "Blueberry",
            "Cherry",
            "Cloudberry",
            "Cocunut",
        ]));

// Echo the fruit back to the terminal
AnsiConsole.WriteLine($"I agree. {fruit} is tasty!");