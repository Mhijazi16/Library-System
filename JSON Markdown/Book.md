# Books

### Access Book 
 <span style='color:  #61e218'>`Query`</span> the database for Book by Id . 

```https://Library/Books/{BookID}```
```json 
"Book" : {
    "Title" : "book name", 
    "Book-ID" : "xxx-xxx-xxx-xxx",
    "AuthorID" : "xxx-xxx-xxx-xxx", 
    "Genre" : "Fiction", 
    "Status" : "Borrowed", 

    "Transactions" : [
        "BookTransaction" : {
            "PatrionID" : "xxx-xxx-xxx-xxx", 

            "BorrowSpan" : {
                "Issue-Date" : "2020-2-2", 
                "Due-Date" : "2020-2-3",
            },
        "BookTransaction" : {
            "PatrionID" : "xxx-xxx-xxx-xxx", 

            "BorrowSpan" : {
                "Issue-Date" : "2020-2-2", 
                "Due-Date" : "2020-2-3",
            },
    ],

    "Reviews" : [
        "Review" : { 
            "PatrionId" : "xx-xxx-xxx-xx",
            "Descriptoin" : "just some random description for the review", 
            "Rating" : 5.7,
        },
        "Review" : { 
            "PatrionId" : "xx-xxx-xxx-xx",
            "Descriptoin" : "just some random description for the review", 
            "Rating" : 5.7,
        }

    ],

}
```

### Search For Book
 <span style='color:  #61e218'>`Query`</span> the database for a book by a filter. 

```https://Library/Books/Genere?=Fiction```

```json 
"Book" : {
    "Title" : "book name", 
    "Book-ID" : "xxx-xxx-xxx-xxx",
    "AuthorID" : "xxx-xxx-xxx-xxx", 
    "Genre" : "Fiction", 
    "Status" : "Borrowed", 

    "BookTransaction" : {
        "PatrionID" : "xxx-xxx-xxx-xxx", 

        "BorrowSpan" : {
            "Issue-Date" : "2020-2-2", 
            "Due-Date" : "2020-2-3",
        },
    },
}
"Book" : {
    "Title" : "book name", 
    "Book-ID" : "xxx-xxx-xxx-xxx",
    "AuthorID" : "xxx-xxx-xxx-xxx", 
    "Genre" : "Fiction", 
    "Status" : "Borrowed", 

    "BookTransaction" : {
        "PatrionID" : "xxx-xxx-xxx-xxx", 

        "BorrowSpan" : {
            "Issue-Date" : "2020-2-2", 
            "Due-Date" : "2020-2-3",
        },
    },
}
```

### Access All Books 
 <span style='color:  #61e218'>`Query`</span> the database for all book . 

```https:/Library/Books```
```json 
"Books" : [
        "BookOne" : {
    "Title" : "book name", 
    "Book-ID" : "xxx-xxx-xxx-xxx",
    "AuthorID" : "xxx-xxx-xxx-xxx", 
    "Genre" : "Fiction", 
    "Status" : "Borrowed", 

    "BookTransaction" : {
        "PatrionID" : "xxx-xxx-xxx-xxx", 

        "BorrowSpan" : {
            "Issue-Date" : "2020-2-2", 
            "Due-Date" : "2020-2-3",
        },
    },
}, 
        "BookTwo" : {
    "Title" : "book name", 
    "Book-ID" : "xxx-xxx-xxx-xxx",
    "AuthorID" : "xxx-xxx-xxx-xxx", 
    "Genre" : "Fiction", 
    "Status" : "Borrowed", 

    "BookTransaction" : {
        "PatrionID" : "xxx-xxx-xxx-xxx", 

        "BorrowSpan" : {
            "Issue-Date" : "2020-2-2", 
            "Due-Date" : "2020-2-3",
        },
    },
},
.....
]
```

### Access all Available Books
 <span style='color:  #61e218'>`Query`</span> the database for all book which are available. 

```https://Library/books/Search?=Available```
```json 
"Books" : [
        "BookOne" : {
    "Title" : "book name", 
    "Book-ID" : "xxx-xxx-xxx-xxx",
    "AuthorID" : "xxx-xxx-xxx-xxx", 
    "Genre" : "Fiction", 
    "Status" : "Available", 

    "BookTransaction" : {
        "PatrionID" : "xxx-xxx-xxx-xxx", 

        "BorrowSpan" : {
            "Issue-Date" : "2020-2-2", 
            "Due-Date" : "2020-2-3",
        },
    },
}, 
        "BookTwo" : {
    "Title" : "book name", 
    "Book-ID" : "xxx-xxx-xxx-xxx",
    "AuthorID" : "xxx-xxx-xxx-xxx", 
    "Genre" : "Fiction", 
    "Status" : "Available", 

    "BookTransaction" : {
        "PatrionID" : "xxx-xxx-xxx-xxx", 

        "BorrowSpan" : {
            "Issue-Date" : "2020-2-2", 
            "Due-Date" : "2020-2-3",
        },
    },
},
.....
]
```

### Borrow a Book 
* Checks if book Available.
* Changes book status to pending  
* Creates an Appeal for borrowing the book.

```https://Library/books/{id}/Actions?=Borrow```

```json
"Appeal" : { 

    "AppealId" : "xx-xxx-xxx-xx",
    "BookId" : "xx-xxx-xxx-xx", 
    "PatrionId" : "xx-xxx-xxx-xx",
    "Type" : "Borrow",
}
```

### Review a Book 
```https://Library/books/{id}/Actions?=Review```
```json
"Review" : { 
    "PatrionId" : "xx-xxx-xxx-xx",
    "Descriptoin" : "just some random description for the review", 
    "Rating" : 5.7,
}
```
### Access all Book Reviews  
```https://Library/books/{id}/Reviews```
```json
"Reviews" : [
    "Review" : { 
        "PatrionId" : "xx-xxx-xxx-xx",
        "Descriptoin" : "just some random description for the review", 
        "Rating" : 5.7,
},
    "Review" : { 
        "PatrionId" : "xx-xxx-xxx-xx",
        "Descriptoin" : "just some random description for the review", 
        "Rating" : 5.7,
}

]
```

