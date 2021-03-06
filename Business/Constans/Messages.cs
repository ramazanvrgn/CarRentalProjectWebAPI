﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
   public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımdadır...";
        public static string CarsAdded = "Araba eklendi...";
        public static string CarsListed = "Arabalar Listelendi...";
        public static string CarsNameInvalid = "Araba ismi geçersiz...";
        public static string CarsDeleted = "Araba silindi...";
        public static string CarsUpdated = "Araba Güncellendi...";

        public static string BrandsAdded = "Araba markası eklendi...";       
        public static string BrandsListed = "Araba markası listelendi...";
        public static string BrandsNameInvalid = "Araba marka ismi geçersiz...";
        public static string BrandsDeleted = "Araba markası silindi...";
        public static string BrandsUpdated = "Araba markası  güncellendi...";

        public static string ColorsAdded = "Araba rengi eklendi...";
        public static string ColorsListed = "Renkler listelendi...";
        public static string ColorsNameInvalid = "Renk ismi geçersiz...";
        public static string ColorsDeleted = "Araba rengi silindi...";
        public static string ColorsUpdated = "Araba rengi  güncellendi...";

        public static string UserAdded = "Kullanıcı eklendi...";
        public static string UsersListed = "Kullanıcılar listelendi...";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz...";
        public static string UserDeleted = "Kullanıcı silindi...";
        public static string UserUpdated = "Kullanıcı  güncellendi...";

        public static string CustomerAdded = "Müşteri eklendi...";
        public static string CustomersListed = "Müşteriler listelendi...";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz...";
        public static string CustomerDeleted = "Müşteri silindi...";
        public static string CustomerUpdated = "Müşteri  güncellendi...";

        public static string RentalAdded = "Kiralama eklendi...";
        public static string RentalsListed = "Kiralamalar listelendi...";
        public static string RentalInvalid = "Kiralama geçersiz...";
        public static string RentalDeleted = "Kiralama silindi...";
        public static string RentalUpdated = "Kiralama  güncellendi...";

        public static string ImageAdded = "Resim Eklendi";
        public static string ImageUptaded = "Resim güncellendi";
        public static string ImageDeleted = "Resim silindi";
        public static string CarImageFull = "Araba en fazla 5 resim alabilir.";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccesfullLogin = "Sisteme Giriş Başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistred = "Kullanıcı başarıyla kaydedildi";
        public static string AccesTokenCreated = "Acces token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
