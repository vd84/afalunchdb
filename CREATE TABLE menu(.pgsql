DROP TABLE IF EXISTS MENU
DROP TABLE IF EXISTS RESTAURANT

CREATE TABLE MENU (
   MENU_ID INT PRIMARY KEY NOT NULL GENERATED ALWAYS AS IDENTITY,
   WEEKDAY INT,
   MENU_NAME VARCHAR(100),
   INGREDIENTS VARCHAR(100),
   PRICE INT,
   RESTAURANT_ID INT NOT NULL,
   CONSTRAINT FK_RESTAURANT
      FOREIGN KEY(RESTAURANT_ID)
         REFERENCES RESTAURANT(RESTAURANT_ID)
);
CREATE TABLE RESTAURANT(
   RESTAURANT_ID INT PRIMARY KEY NOT NULL GENERATED ALWAYS AS IDENTITY,
   RESTAURANT_NAME VARCHAR(255) NOT NULL,
   PHONE VARCHAR(15) NOT NULL,
   ADDRESS VARCHAR(100) NOT NULL
);



INSERT INTO RESTAURANT (RESTAURANT_NAME, PHONE, ADDRESS) VALUES ('DiWine', '08-212885', 'Drottninggatan 25')
INSERT INTO RESTAURANT (RESTAURANT_NAME, PHONE, ADDRESS) VALUES ('ILMOLO', '08-20 36 30', 'Hamngatan 37')

INSERT INTO MENU (WEEKDAY, MENU_NAME, INGREDIENTS, PRICE, RESTAURANT_ID) VALUES (0,'Köttbullar med potatis', 'Brunsås och lingon', 120, 1)