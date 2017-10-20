using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
using System.Threading.Tasks;

namespace libValidaciones
{
    public class Val
    {
        //VALIDA EL NOMBRE
        public static bool NombrePersonal(string nom)
        {
            Regex regex = new Regex(@"^([A-Z]{1}[a-zñáéíóú]+[\s]*)+$");
            return regex.IsMatch(nom);
        }      
        //VALIDA EL RFC
        public static bool RFC(string rfcValidar)
        {
            Regex regEx = new Regex(@"^(([A-Z]|[a-z]|){1})(([A-Z]|[a-z]){3})([0-9]{6})((([A-Z]|[a-z]|[0-9]){3}))$");
            return regEx.IsMatch(rfcValidar);
        }
        //VALIDA LA CURP
        public static bool CURP(string curpValidar)
        {
            Regex regEx = new Regex(@"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9][12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$");
            return regEx.IsMatch(curpValidar);
        }
        //VALIDA EL CORREO
        public static bool CORREO(string correoValidar)
        {
            Regex regEx = new Regex(@"^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$");
            return regEx.IsMatch(correoValidar);
        }
        //VALIDA EL CELULAR
        public static bool celular(string celularValidar)
        {
            Regex regEx = new Regex(@"^\((5|6|4)[0-9]{2}\)(\s|-)?[0-9]{7}$");
            return regEx.IsMatch(celularValidar);
        }
        public static bool codigoPostal(string codigopostal)
        {
            Regex regEx = new Regex(@"\^([1-9]{2}|[0-9][0-9][0-9]){3}$");
            return regEx.IsMatch(codigopostal);
        }
        public static bool ineclave(string claveelector)
        {
            Regex regEx = new Regex(@"\^.* (?=.{ 18 })[+-]?\d+(\.\d+)?$");
            return regEx.IsMatch(claveelector);
        }
        public static bool letras(string Sololetras)
        {
            Regex regEx = new Regex(@"^[a-zA-ZñÑ\s]");
            return regEx.IsMatch(Sololetras);
        }
        public static bool numeros(string Num)
        {
            Regex regEx = new Regex(@"^[0-9]{1,9}(\.[0-9]{0,2})?$");
            return regEx.IsMatch(Num);
        }
        public static bool doublee(string doub)
        {
            Regex regEx = new Regex(@"^([0-9])*[.]?[0-9]*$");
            return regEx.IsMatch(doub);
        }
        public static bool decimall(string decimaly)
        {
            Regex regEx = new Regex(@"^(\d|-)?(\d|,)*\.?\d*$");
            return regEx.IsMatch(decimaly);
        }
        public static bool stringg(string stringito)
        {
            Regex regEx = new Regex(@"^[a-zA-Z]+(\s*[a-zA-Z]*)*[a-zA-Z]+$");
            return regEx.IsMatch(stringito);
        }
    }
}
