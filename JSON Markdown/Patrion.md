# Patrion

### Access Patrion
```https://Library/Patrions/{id}```
```json 
"Patrion" : {
    "FirstName" : "Moahmmed",
    "LastName" : "Hijazi", 
    "Email" : "example@gmail.com", 

    "Books" : [
        "BookOne" : {
            ....
        },
        "BookTwo" : {
            ....
        }, 
    ],

    "TransactionHistory" : [
        "Transaction" : {

            "TransactionId" : "xxx-xxx-xxx-xxx",
            "BookID" : "xxx-xxx-xxx-xxx", 
            "PatrionID" : "xxx-xxx-xxx-xxx",
            "Type" : "Borrow", 
            "Status" : "Success",

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

        "Transaction" : {

            "TransactionId" : "xxx-xxx-xxx-xxx",
            "BookID" : "xxx-xxx-xxx-xxx", 
            "PatrionID" : "xxx-xxx-xxx-xxx",
            "Type" : "Borrow", 
            "Status" : "Success",

            "BorrowSpan" : {
                "IssueDate" : "2023-2-2",
                "DueDate" : "2023-3-3",
            },
        }, 

        "Transaction" : {

            "TransactionId" : "xxx-xxx-xxx-xxx",
            "BookID" : "xxx-xxx-xxx-xxx", 
            "PatrionID" : "xxx-xxx-xxx-xxx",
            "Type" : "Borrow", 
            "Status" : "Failure",

            "BorrowSpan" : {
                "IssueDate" : "2023-2-2",
                "DueDate" : "2023-3-3",
            },
        }
    ]
```

### Show OverDue Books
```https://Library/Patrions/{id}/BorrowHistory/Filter?=showDue```
```json 
"TransactionsHistory" : [
        "TransactionOne" : {
            "BookID" : "xxx-xxx-xxx-xxx", 
            "PatrionID" : "xxx-xxx-xxx-xxx",
            "Type" : "Borrow", 
            "State" : "Succeeded",
 
            "BorrowSpan" : {
                "IssueDate" : "2023-2-2",
                "DueDate" : "2023-3-3",
            },
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