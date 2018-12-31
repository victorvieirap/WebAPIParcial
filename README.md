# WebAPIParcial
Servicio Web que permite registrar clientes y transacciones, un cliente puede tener varias transacciones.

Nos limitamos a colocar nada mas el POST y GET ya que se pedia solo registro de clientes y transcciones. El PUT y DELETE que completan el RESTful estan como metodos privados, por eso no se ven en la API pero si estan implementados.

-----------------------------------------------------------------------------------------------------------------------------------

Endpoint registro de usuarios:  http://localhost:3010/api/usuarios  .
Ejemplo de archivo JSON de entrada para registro de usuarios:

{
	"Id":0,
	"clave":"123456",
	"correo":"joseperez@gmail.com",
	"apellidos":"perez romero",
	"nombres":"jose manuel"
}

-----------------------------------------------------------------------------------------------------------------------------------

Endpoint registro de transacciones: http://localhost:3010/api/transacciones  .
Ejemplo de dos (2) archivos JSON de entrada para registro de transacciones al cliente de id cero (0):

{
	"Id":0,
	"usuario":0,
	"fecha":"12/28/2018 22:35:12",
	"monto":937.35
}


{
	"Id":1,
	"usuario":0,
	"fecha":"12/30/2018 18:20:45",
	"monto":12500.50
}

-----------------------------------------------------------------------------------------------------------------------------------

Endpoint consulta cliente:  http://localhost:3010/api/usuarios/0   .
Archivo JSON de salida, si se realiza una consulta del cliente previamente registrado:

{
    "transaccion": [
        {
            "Id": 0,
            "usuario": 0,
            "fecha": "2018-12-28T00:00:00",
            "monto": 937.35
        },
        {
            "Id": 1,
            "usuario": 0,
            "fecha": "2018-12-30T00:00:00",
            "monto": 12500.5
        }
    ],
    "Id": 0,
    "nombres": "jose manuel",
    "apellidos": "perez romero",
    "correo": "joseperez@gmail.com",
    "clave": "123456"
}


