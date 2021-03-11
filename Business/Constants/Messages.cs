using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages 
        //newlememek için static
    {
        public static string SuccessAdded = "Ekleme işlemi başarılı";
        public static string ErrorAdded = "Ekleme işlemi hatalı";

        public static string SuccessDeleted = "Silme işlemi başarılı";
        public static string ErrorDeleted = "Silme işlemi başarısız";

        public static string SuccessUpdated = "Güncelleme işlemi başarılı";
        public static string ErrorUpdated = "Güncelleme işlemi başarısız";

        public static string SuccessListed = "Listeleme işlemi başarılı";
        public static string ErrorListed="Listeleme işlemi başarısız";

        public static string CharacterNameInValid = "Karakter ismi geçersiz,girdiğiniz karakter en az 2 karakter olmalı";
        public static string ValueError = "Günlük fiyat 0 dan büyük olmalı";

        public static string MaintenanceTime = "Sistem bakımda !";

        public static string NotReturned = "Araba teslim edilmediği için kiralayamazsınız";

        public static string TheNumberOfImagesUploadedHasExceeded = "Yüklenen resim sayısı aşıldı";

        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string PasswordError = "Hatalı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";

    }
}
