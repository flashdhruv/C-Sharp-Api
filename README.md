# C# Api
A project with the aim to use C# and .Net to create an HTTP endpoint.
The aim of the endpoint was to accept a bunch of JSON objects in an array
and replace the string "dog" with "cat" whereever there may be an occurence.

For tests, A unit test has been created and just needs to be run. 
Running the program and using postman works too. 

To check if the project is working, build and run the solution.
Then add "https://localhost:7065/replaceDogWithCat" as the url in postman. 
Change the type of request to POST.
Add the demo payload seen below.
Hit send. The expected result should appear.

# Here's an example payload sent in the body of the request:
[
                         {
                             "name":"dog Doe",
                             "age": 30,
                             "department":"doggy"
                         }
]  

# and the expected result is:

    "value": [
        {
            "name": "cat doe",
            "age": "30",
            "department": "doggy"
        }
    ],
    "formatters": [],
    "contentTypes": [],
    "declaredType": null,
    "statusCode": 200
}

# Things that could be improved include:

1) Possible uses of databases
2) Possibly creating views to display the data 
3) Creating a form to input the data that needs to be updated
