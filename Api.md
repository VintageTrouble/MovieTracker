# Movie Tracker API

- [Movie Tracker AP](#movie-tracker-api)
	- [Auth](#auth)
		- [Register](#register)
			- [Register Request](#register-request)
			- [Register Response](#register-response)
		- [Login](#login)
			- [Login Request](#login-request)
			- [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
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
200 OK
```

```json
{
	"id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
	"firstName": "John",
	"lastName": "Doe",
	"email": "JohnDoe@gmail.com",
	"token": "eyJhb..hbbQ"
}
```

### Login

```js
POST {{host}}/auth/login
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
	"id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
	"firstName": "John",
	"lastName": "Doe",
	"email": "JohnDoe@gmail.com",
	"token": "eyJhb..hbbQ"
}
```