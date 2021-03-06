CREATE TABLE MENU(
   MENU_ID INT PRIMARY KEY,
   CUSTOMER_NAME VARCHAR(255) NOT NULL,
   RESTAURANT_ID INT,
   CONSTRAINT FK_RESTAURANT
      FOREIGN KEY(RESTAURANT_ID)
	  REFERENCES RESTAURANT(ID)
);

CREATE TABLE RESTAURANT (
   ID INT PRIMARY KEY,
   RESTAURANT_NAME VARCHAR(255) NOT NULL,
   PHONE VARCHAR(15),
   ADRESS VARCHAR(100)
);