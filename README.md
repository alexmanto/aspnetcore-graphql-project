# Real Estate Manager

## Introdution
This is an example of a project using GraphQL with .Net Core, in this project it is possible to see a little about queries and mutations, in addition to configuring GraphQL Server in a WebApi with AspNet Core.

This project is based on the [**GraphQL Tutorial**](https://www.youtube.com/watch?v=M0L2aqVOPnM&list=PLBMCyCQ4nalaWRYBDKrIOHkFK1Y5AxbrK&index=1) of the [**Full-Stack Dev**](https://www.youtube.com/channel/UCUIDjzFiyBau5o1RhU-qJkw) channel.

## Getting Started

### Steps to execute the project in a development environment
1. Clone the repository.
2. Open the project and run it through IIS Express.
3. Access the GraphQL API on port `44306` and route `graphql`, as shown in the following example.
    `https://localhost:44306/graphql/`

### Samples of queries and mutations.

* Queries
    * All properties
        ```json
        {
            properties {
                id
                name
            }
        }
        ```

    * Property by id
        ```json
        {
            property(id: 4) {
                id
                name
            }
        }
        ```

* Mutations
    * Adding a new property
        * Query
            ```json
            mutation AddPropertyMutation($property: PropertyInput!) {
                addProperty(property: $property) {
                    id
                    name
                }
            }
            ```
        * Query Variables
            ```json
            {
                "property": {
                    "name": "Test Name",
                    "street": "Test Street",
                    "city": "Test City",
                    "family": "Test Family"
                }
            }
            ```

## Useful links
* [**GraphQL Tutorial - Full-Stack Dev channel**](https://www.youtube.com/watch?v=M0L2aqVOPnM&list=PLBMCyCQ4nalaWRYBDKrIOHkFK1Y5AxbrK&index=1)
* [**GraphQL in .NET - Code Traveler**](https://codetraveler.io/dotnetgraphql/)
* [**Using Postman with GraphQL APIs - Code Traveler**](https://codetraveler.io/2019/01/12/how-to-use-postman-with-a-graphql-api/)
* [**GraphQL .NET - Docs**](https://graphql-dotnet.github.io/docs/getting-started/introduction)
* [**GraphQL .NET - GitHub**](https://github.com/graphql-dotnet)
* [**Criando API GraphQL com .Net Core parte 1 - Medium**](https://medium.com/@jozimar5/criando-api-graphql-com-net-core-cbe6618eb425)
* [**Criando API GraphQL com .Net Core parte 2 - Medium**](https://medium.com/@jozimar5/criando-api-graphql-com-net-core-parte-2-5d60abe920e9)
* [**Lessons From 4 Years of GraphQL - Explore GraphQL**](https://www.graphql.com/articles/4-years-of-graphql-lee-byron)