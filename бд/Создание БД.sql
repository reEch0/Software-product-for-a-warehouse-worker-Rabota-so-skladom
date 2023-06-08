CREATE TABLE Klient
(
  Mail VARCHAR NOT NULL,
  Gorod VARCHAR NOT NULL,
  Adres VARCHAR NOT NULL,
  Imia varchar NOT NULL,
  Familia varchar NOT NULL,
  KlientID NUMERIC NOT null check(KlientID >0),
  PRIMARY KEY (KlientID)
);

CREATE TABLE Zakaz
(
  ZakazID NUMERIC NOT null check(ZakazID >0),  
  Data_zakaza DATE NOT null check(Data_zakaza = current_date),
  Data_dostavki Date not null check(Data_dostavki > current_date),
  KlientID NUMERIC NOT NULL,
  PRIMARY KEY (ZakazID),
  FOREIGN KEY (KlientID) REFERENCES Klient(KlientID)
);

CREATE TABLE Tovar
(
  TovarID NUMERIC NOT null check(TovarID >0),
  Nazvanie VARCHAR NOT NULL,
  Opisanie VARCHAR NOT NULL,
  Cena NUMERIC NOT null check(Cena > 0),
  Vid VARCHAR NOT NULL,
  PRIMARY KEY (TovarID)
);

CREATE TABLE ZakazTovarov
(
  ZakazID NUMERIC NOT NULL,
  TovarID NUMERIC NOT NULL,
  FOREIGN KEY (ZakazID) REFERENCES Zakaz(ZakazID),
  FOREIGN KEY (TovarID) REFERENCES Tovar(TovarID)
);