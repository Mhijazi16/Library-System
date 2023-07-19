# Librarian 
----

### Access all Appeals
```https://Library/Appeals```
```json 
"Appeals" : [
    "AppealOne" : {
        "AppealId" : "xx-xx-xx-xx",
        "BookId" : "xx-xx-xx-xx",
        "PatrionId" : "xx-xx-xx-xx",
        "State" : "Success",
        "Type" : "Borrow",
    }

    "AppealTwo" : {
        "AppealId" : "xx-xx-xx-xx",
        "BookId" : "xx-xx-xx-xx",
        "PatrionId" : "xx-xx-xx-xx",
        "State" : "Success",
        "Type" : "Return",
    }

    "AppealThree" : {
        "AppealId" : "xx-xx-xx-xx",
        "BookId" : "xx-xx-xx-xx",
        "PatrionId" : "xx-xx-xx-xx",
        "State" : "Failure",
        "Type" : "Borrow",
    }
]
```

### Access All Borrow Appeals
```https://Library/apeals/Type?=borrowed```
```json 
"Appeals" : [
    "AppealOne" : {
        "AppealId" : "xx-xx-xx-xx",
        "BookId" : "xx-xx-xx-xx",
        "PatrionId" : "xx-xx-xx-xx",
        "State" : "Success",
        "Type" : "Borrow",
    },

    "AppealTwo" : {
        "AppealId" : "xx-xx-xx-xx",
        "BookId" : "xx-xx-xx-xx",
        "PatrionId" : "xx-xx-xx-xx",
        "State" : "Failure",
        "Type" : "Borrow",
    },
],
``` 

### Access All Return Appeals
```https://Library/apeals/Type?=return```
```json 
"Appeals" : [
    "AppealOne" : {
        "AppealId" : "xx-xx-xx-xx",
        "BookId" : "xx-xx-xx-xx",
        "PatrionId" : "xx-xx-xx-xx",
        "State" : "Success",
        "Type" : "Return",
    },

    "AppealTwo" : {
        "AppealId" : "xx-xx-xx-xx",
        "BookId" : "xx-xx-xx-xx",
        "PatrionId" : "xx-xx-xx-xx",
        "State" : "Pending",
        "Type" : "Return",
    },
],
```

### Access an Appeal 
```https://Library/apeals/{id}```
```json

    "AppealThree" : {
        "AppealId" : "xx-xx-xx-xx",
        "BookId" : "xx-xx-xx-xx",
        "PatrionId" : "xx-xx-xx-xx",
    }

```

### Accept an Appeal 
```https://Library/apeals/{id}/Actions?=accept```
```json
  "TransactionOne" : {
            "PatrionId" : "xx-xx-xx-xx",
            "BookID" : "xxx-xxx-xxx-xxx", 
            "State"  : "Success"
            "BorrowSpan" : {
                "IssueDate" : "2023-2-2",
                "DueDate" : "2023-3-3",
            },
        }
```

### Reject an Appeal 
```https://Library/apeals/{id}/Actions?=reject```
```json
  "TransactionOne" : {
            "PatrionId" : "xx-xx-xx-xx",
            "BookID" : "xxx-xxx-xxx-xxx", 
            "State"  : "Failure"
            "BorrowSpan" : null, 
        }
```