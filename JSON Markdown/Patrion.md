# Patrion

### Access Patrion
```https://Library/Patrions/{id}```
```json 
"Patrion" : {
    "Name" : "Mohammed", 
    "Email" : "example@gmail.com", 

    "Books" : [
        "BookOne" : {
            ....
        },
        "BookTwo" : {
            ....
        }, 
    ],

    "BorrowHistory" : [
        "Transaction" : {
            "BookID" : "xxx-xxx-xxx-xxx", 
            "BorrowSpan" : {
                "IssueDate" : "2023-2-2",
                "DueDate" : "2023-3-3",
            },
        },
    ]
}
```

### Access All Patrions 
```https://Library/Patrions```
```json
"Patrions" : [
    "PatrionOne" : {
        .........
    }
    "PatrionTwo" : {
        .........
    }
    "PatrionThree" : {
        .........
    }
]
```

### Show Borrow History 
```https://Library/Patrions/{id}/BorrowHistory```
```json 
"TransactionsHistory" : [
        "TransactionOne" : {
            "BookID" : "xxx-xxx-xxx-xxx", 
            "BorrowSpan" : {
                "IssueDate" : "2023-2-2",
                "DueDate" : "2023-3-3",
            },
        },

        "TransactionTwo" : {
            "BookID" : "xxx-xxx-xxx-xxx", 
            "BorrowSpan" : {
                "IssueDate" : "2023-2-2",
                "DueDate" : "2023-3-3",
            },
        },
 
    ]
```

### Show OverDue Books
```https://Library/Patrions/{id}/BorrowHistory/Filter?=showDue```
```json 
"TransactionsHistory" : [
        "TransactionOne" : {
            "BookID" : "xxx-xxx-xxx-xxx", 
            "BorrowSpan" : {
                "IssueDate" : "2023-2-2",
                "DueDate" : "2023-3-3",
            },
            "Type" : "Borrow", 
            "State" : "Succeeded",
        },
    ]
```

### Show Borrowed Books
```https://Library/patrions/{id}/Books```
```json
"Books" : [
    "BookOne" : {
        ......
    },
    "BookTwo" : {
        ......
    }
]
```
### Return a Book 
```https://Library/patrions/{id}/books/{id}/Action?=Return```

```json
    "Appeal" : { 
        "AppealId" : "xx-xxx-xxx-xx",
        "BookId" : "xx-xxx-xxx-xx", 
        "PatrionId" : "xx-xxx-xxx-xx"
        "Type" : "Return" 

    }
```