# xTangoFacturas

#### Integracion mediante el ingreso de facturación a Sistema Tango utilizando xTango

---

**[Sistema Tango Axoft](http://www.axoft.com/) |**
**[Documentacion xTango](ftp://ftp.tangosoft.com.ar/manuales/14.11/Gestion/Automatizadores.pdf) |**
**[Reportar Errores](https://github.com/mescalitog/xTangoFacturas/issues/new) |**
**[Este Repositorio](https://github.com/mescalitog/xTangoFacturas) |**

---


## Descripción

Prueba de concepto de ingreso de facturas a Tango Axoft mediante la integracion con xTango.
xTango permite la integracion del [Sistema Tango Axoft](http://www.axoft.com/) con otros sistemas en forma segura.

## Pre-requisitos

Para utilizar la aplicación debe tener instalado:

- .Net framework 4.5 
- [Sistema Tango Axoft](http://www.axoft.com/) con los objetos active x registrados. Se pueden registrar desde el administrador.


**Note:** *Esta versión fue probada con la versión 10.0 de [Sistema Tango Axoft](http://www.axoft.com/)*


## Como funciona

- Las facturas se ingresan a *Tango* mediante el intercambio de obsoletos ADODB.Recordset 
- El "modelo" de los registros se crea mediante la generación de _estructuras_ en *Tango*.
- La aplicación almacena las _estructuras_ en archivos xml en el directorio _Estructuras_, si estos archivos se borran, la aplicación los creará nuevamente al iniciar sesión en *Tango*
- La opción **Reconstruir Estructuras** permite reconstruir las estructuras (generar nuevamente los xmls)
- Las _estructuras_ deben ser las que corresponden a la versión de *Tango* que se está usando. **Es recomendable reconstruir las estructuras la primera vez**

Una vez que tenga la conexión a *Tango* y las estructuras creadas podrá completar los campos de las _grillas_ y haciendo click en el botón _Ingresar Facturas_ ingresar las _facturas_ a *Tango*.
Se debe tener en cuenta que los códigos ingresados en los campos que requieren códigos, como _vendedor_ o _código de impuesto_ deben estar creados en *Tango*
*Tango* informa sobre el resultado de la incorporación de las facturas en la solapa _*Resultados*_

**Note:** *NO LO UTILICE EN SISTEMAS EN PRODUCCION*

## Otras opciones

- *Reconstruir Estructuras* permite reconstruir las estructuras (generar nuevamente los xmls) **Recomendado**
- *Cargar Datos* Carga datos por default desde archivos xml. 
- *Grabar Datos* Graba los datos por default a archivos xml.
- *Salvar Resultado* Permite grabar el contenido de la solapa *Resultados*