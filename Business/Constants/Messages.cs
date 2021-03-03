using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Succes = "✔️ SUCCESS ✔️";
        public static string Error = "ERROR ❌";
        public static string Listing = "SUCCESS .... ✔️";
        public static string MainttenanceTime = " ✔️ BAKIM ZAMANI ✔️";
        public static string LoadingList = "WAIT FOR LOADING";
        public static string SuccessAdded = "Adding successful ✔️ ";
        public static string ErrorAdded = "Adding Unsuccessful ❌";
        public static string DeleteSuccess = "✔️ Deletion is Successful ✔️";
        public static string DeleteError = "Deletion is Unsuccessful";
        public static string UpdateSuccess = "✔️ Update is Successful ✔️";
        public static string UpdateError = "✔️ Update is Unsuccessful ✔️";
        public static string AdminNameMailAlreadyExists = "Bu isimde başka isim var";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayıt oldu.";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı Mevcut";
        public static string AccessTokenCreated="Token Oluşturuldu";
    }
}
