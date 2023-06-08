CREATE TABLE Klient
(
  Mail VARCHAR(100) NOT NULL,
  Gorod VARCHAR(100) NOT NULL,
  Adres VARCHAR(100) NOT NULL,
  Imia varchar(100) NOT NULL,
  Familia varchar(100) NOT NULL,
  KlientID NUMERIC identity(1,1),
  PRIMARY KEY (KlientID)
);

CREATE TABLE Zakaz
(
  ZakazID NUMERIC identity(1,1),  
  Data_zakaza DATE NOT null,
  Data_dostavki Date not null,
  KlientID NUMERIC NOT NULL,
  PRIMARY KEY (ZakazID),
  FOREIGN KEY (KlientID) REFERENCES Klient(KlientID)
);

CREATE TABLE Tovar
(
  TovarID NUMERIC identity(1,1),
  Nazvanie VARCHAR(1000) NOT NULL,
  Opisanie VARCHAR(8000) NOT NULL,
  Cena NUMERIC(20) NOT null check(Cena > 0),
  Vid VARCHAR(100) NOT NULL,
  KolVo_tovara numeric(5) not null,
  PRIMARY KEY (TovarID)
);

CREATE TABLE ZakazTovarov
(
  ZakazID NUMERIC NOT NULL,
  TovarID NUMERIC NOT NULL,
  FOREIGN KEY (ZakazID) REFERENCES Zakaz(ZakazID),
  FOREIGN KEY (TovarID) REFERENCES Tovar(TovarID)
);