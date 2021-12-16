# Standard deck of card

- [Setup](#setup)
- [Development Guideline](#development-guideline)
  - [Writing code & format](#writing-code-linting--format)
  - [Testing, code-coverage](#testing-code-coverage)
- [TODO](#todo)

## System overview

This is a Decking card example application, that does 2 actions: randomly shuffles a standard deck of 52 playing cards and sort a standard deck of 52 playing cards in ascending order.

The ascending order term is defined by the increment of card's type (clubs -> spades -> hearts -> diamonds) and it's value (Ace = 1, 2, 3, 4, 5,... Jack = 11, Queen = 12, King = 13). If 2 card has the same type then sort them by their values ascending

The source code contains 3 project: 
- `DeckCard.App` is the main one, has console type, used to run the console and print 2 outputs of 2 function: shuffer and sort card
- `DeckCard.Libs` is the class library project that contains common things that provides functions and models for main project to run
- `DeckCard.Test` is the NUnit test project that checks the test cases of 2 functions above

## Development Guideline

### Testing, code-coverage
Testing is done with **dotnet test**. Run the full test suite with

| Function                       | Not covered | % Not covered | Covered  | % Covered    |
|--------------------------------|-------------|---------------|----------|--------------|
| GenerateRandomCardsCollection  | 0           | 0%            | 18       | 100%         |
| SortAscending                  | 0           | 0%            | 6        | 100%         |
| `<`SortAscending`>`b__1_0(CardModel, CardModel)   | 0      | 0%      | 3    | 100%     |

Coverage report format is export as `test-coverage.xml`.
## TODO
- [x] Provide `GenerateRandomCardsCollection` function that randomly shuffles a standard deck of 52 playing cards
- [x] Provide `SortAscending` that sorts a standard deck of 52 playing cards in ascending order
- [x] Write test cases for 2 functions above
- [x] Export test coverage `<SortAscending>b__1_0(DeckCard.Model.CardModel, DeckCard.Model.CardModel)`