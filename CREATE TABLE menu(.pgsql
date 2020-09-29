CREATE TABLE MENU (
   MENU_ID INT PRIMARY KEY NOT NULL,
   RESTURANT_ID INT NOT NULL,
   CONSTRAINT FK_RESTAURANT
      FOREIGN KEY(RESTURANT_ID)
         REFERENCES RESTAURANT(RESTAURANT_ID)
);
CREATE TABLE RESTAURANT(
   RESTAURANT_ID INT PRIMARY KEY NOT NULL,
   RESTAURANT_NAME VARCHAR(255) NOT NULL,
   PHONE VARCHAR(15) NOT NULL,
   ADDRESS VARCHAR(100) NOT NULL
);