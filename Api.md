# Movie Tracker API

- [Movie Tracker AP](#movie-tracker-api)
	- [Error Response](#error-response)
	- [Auth](#auth)
		- [Register](#register)
			- [Register Request](#register-request)
			- [Register Response](#register-response)
			- [Register Errors](#register-errors)
		- [Login](#login)
			- [Login Request](#login-request)
			- [Login Response](#login-response)
			- [Login Errors](#login-errors)
	- [Movie](#movie)
		- [Get Movie](#get-movie)
			- [Get Movie Response](#get-movie-response)
			- [Get Movie Errors](#get-movie-errors)
		- [New Movie](#new-movie)
			- [New Movie Request](#new-movie-request)
			- [New Movie Response](#new-movie-response)
			- [New Movie Errors](#new-movie-errors)

## Auth

### Error Response

```json
{
	"type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
	"title": "One or more validation errors occurred.",
	"status": 400,
	"traceId": "00-7718740d16a4124782dca3c04eefdf0a-538bd0b5976d4c5a-00",
	"errors": {
		"Email": [
			"'Email' invalid email address."
		]
	}
}
```

### Register

```js
POST {{host}}/api/auth/register
```

#### Register Request

```json
{
	"firstName": "John",
	"lastName": "Doe",
	"email": "JohnDoe@gmail.com",
	"password": "Password123"
}
```

#### Register Response

```js
201 CREATED
```

```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"firstName": "John",
	"lastName": "Doe",
	"email": "JohnDoe@gmail.com",
	"token": "eyJhb..hbbQ"
}
```

#### Register Errors

```js
400 BAD REQUEST
```

```js
409 CONFLICT
```

```js
500 INTERNAL SERVER ERROR
```

### Login

```js
POST {{host}}/api/auth/login
```

#### Login Request

```json
{
	"email": "JohnDoe@gmail.com",
	"password": "Password123"
}
```

#### Login Response

```js
200 OK
```

```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"firstName": "John",
	"lastName": "Doe",
	"email": "JohnDoe@gmail.com",
	"token": "eyJhb..hbbQ"
}
```

#### Login Errors

```js
400 BAD REQUEST
```

```js
500 INTERNAL SERVER ERROR
```

## Movie

### Get Movie

```js
GET {{host}}/api/movie/{id}
```

#### Get Movie Response

```js
200 OK
```

```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"title": "Movie Name",
	"description": "Movie description",
	"Rate": 9.5,
	"releaseDate": "2022-08-26T00:00:00"
}
```

#### Get Movie Errors

```js
400 BAD REQUEST
```

```js
500 INTERNAL SERVER ERROR
```

### New Movie

```js
POST {{host}}/api/movie/new
```

#### New Movie Request

```json
{
	"title": "Movie Name",
	"description": "Movie description", 
	"releaseDate": "2022-08-26T00:00:00"
}
```

#### New Movie Response

```js
201 CREATED
```

```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"title": "Movie Name",
	"description": "Movie description",
	"Rate": 0,
	"releaseDate": "2022-08-26T00:00:00"
}
```

#### New Movie Errors

```js
400 BAD REQUEST
```

```js
500 INTERNAL SERVER ERROR
```