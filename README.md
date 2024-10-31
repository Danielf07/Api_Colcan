# API REST para Gestión de Pacientes

Esta es una API REST diseñada para gestionar la información de pacientes. Proporciona operaciones CRUD (Crear, Leer, Actualizar y Eliminar) para los datos de pacientes. La API permite almacenar y administrar información de pacientes de manera eficiente y segura.

## Características

- **GET**: Recuperar información de pacientes.
- **POST**: Crear un nuevo paciente.
- **PUT**: Actualizar la información de un paciente existente.
- **DELETE**: Eliminar un paciente.

## Endpoints

### Obtener todos los pacientes

- **URL**: `/api/Pacientes`
- **Método**: `GET`
- **Descripción**: Recupera una lista de todos los pacientes.
- **Respuesta Exitosa**:
  - **Código**: `200 OK`
  - **Contenido**: Lista de objetos de pacientes.

#### Ejemplo de Respuesta
```json
[
  {
    "id": 1,
    "tipoDocumento": "CC",
    "numeroDocumento": 1053000000,
    "nombre": "Daniel",
    "fechaNacimiento": "1994-10-31T19:52:31.807",
    "email": "daniel@gmail.com",
    "genero": "M",
    "direccion": "Calle 321",
    "numeroTelefono": 318000000,
    "activo": true
  },
  {
    "id": 2,
    "tipoDocumento": "CC",
    "numeroDocumento": 1085000000,
    "nombre": "Fernando",
    "fechaNacimiento": "1994-08-31T19:52:31.807",
    "email": "fernando@gmail.com",
    "genero": "M",
    "direccion": "Calle 123",
    "numeroTelefono": 310000000,
    "activo": false
  },
]
```

### Obtener un paciente por ID

- **URL**: `/api/pacientes/{id}`
- **Método**: `GET`
- **Descripción**: Recupera la información de un paciente específico.
- **Parámetros**:
  - **id (int): ID del paciente.
- **Respuesta Exitosa**:
  - **Código**: `200 OK`
  - **Contenido**: Objeto del paciente solicitado.

#### Ejemplo de Respuesta
```json
 {
    "id": 2,
    "tipoDocumento": "CC",
    "numeroDocumento": 1085000000,
    "nombre": "Fernando",
    "fechaNacimiento": "1994-08-31T19:52:31.807",
    "email": "fernando@gmail.com",
    "genero": "M",
    "direccion": "Calle 123",
    "numeroTelefono": 310000000,
    "activo": false
  }
```

### Crear un nuevo paciente

- **URL**: `/api/pacientes`
- **Método**: `POST`
- **Descripción**: Agrega un nuevo paciente a la base de datos.
- **Cuerpo de la solicitud**:
  ```json
   {
    "id": 2,
    "tipoDocumento": "CC",
    "numeroDocumento": 1085000000,
    "nombre": "Fernando",
    "fechaNacimiento": "1994-08-31T19:52:31.807",
    "email": "fernando@gmail.com",
    "genero": "M",
    "direccion": "Calle 123",
    "numeroTelefono": 310000000,
    "activo": false
  }
  ```
- **Respuesta Exitosa**:
  - **Código**: `201 Created`
  - **Contenido**: Objeto del paciente creado con su id.

#### Ejemplo de Respuesta
```json
 {
    "id": 2,
    "tipoDocumento": "CC",
    "numeroDocumento": 1085000000,
    "nombre": "Fernando",
    "fechaNacimiento": "1994-08-31T19:52:31.807",
    "email": "fernando@gmail.com",
    "genero": "M",
    "direccion": "Calle 123",
    "numeroTelefono": 310000000,
    "activo": false
  }
```

### Actualizar información de un paciente

- **URL**: `/api/pacientes/{id}`
- **Método**: `PUT`
- **Descripción**: Actualiza la información de un paciente existente.
- **Parámetros**:
  - **id (int): ID del paciente.
- **Cuerpo de la solicitud**:
  ```json
   {
    "id": 2,
    "tipoDocumento": "CC",
    "numeroDocumento": 1085000000,
    "nombre": "Fernando",
    "fechaNacimiento": "1994-08-31T19:52:31.807",
    "email": "fernando@gmail.com",
    "genero": "M",
    "direccion": "Calle 123",
    "numeroTelefono": 310000000,
    "activo": false
  }
  ```
- **Respuesta Exitosa**:
  - **Código**: `200 OK`
  - **Contenido**: Objeto del paciente actualizado.

#### Ejemplo de Respuesta
```json
 {
    "id": 2,
    "tipoDocumento": "CC",
    "numeroDocumento": 1085000000,
    "nombre": "Fernando",
    "fechaNacimiento": "1994-08-31T19:52:31.807",
    "email": "fernando@gmail.com",
    "genero": "M",
    "direccion": "Calle 123",
    "numeroTelefono": 310000000,
    "activo": false
  }
```

### Eliminar un paciente

- **URL**: `/api/pacientes/{id}`
- **Método**: `DELETE`
- **Descripción**: Elimina un paciente de la base de datos.
- **Parámetros**:
  - **id (int): ID del paciente.
- **Cuerpo de la solicitud**:
  ```json
   {
    "id": 2,
    "tipoDocumento": "CC",
    "numeroDocumento": 1085000000,
    "nombre": "Fernando",
    "fechaNacimiento": "1994-08-31T19:52:31.807",
    "email": "fernando@gmail.com",
    "genero": "M",
    "direccion": "Calle 123",
    "numeroTelefono": 310000000,
    "activo": false
  }
  ```
- **Respuesta Exitosa**:
  - **Código**: `204 No Content`
