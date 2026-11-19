CREATE DATABASE SmartMed

GO
CREATE SCHEMA vaccine
GO
--User Table--
CREATE TABLE vaccine.Users(userId INT IDENTITY(1,1) PRIMARY KEY ,username VARCHAR(50) NOT NULL UNIQUE , userPassword VARCHAR(255) NOT NULL UNIQUE ,email VARCHAR(100) NOT NULL UNIQUE, userRole VARCHAR(50));

--Vaccine Table--
CREATE TABLE vaccine.vaccines( vaccineId INT IDENTITY(1,1) PRIMARY KEY, vaccineName VARCHAR(100), manufacturer NVARCHAR(100), batchNumber VARCHAR(50), expiryDate DATETIME, minTemp DECIMAL(5,2), maxTemp DECIMAL(5,2), quantity INT);

--Shipment Table--
CREATE TABLE vaccine.shipments( shipmentId INT IDENTITY(1,1) PRIMARY KEY,
								vaccineId INT ,
								CONSTRAINT FK_shipment_vaccines FOREIGN KEY (vaccineId)  REFERENCES vaccine.vaccines(vaccineId),
								sourceLocation VARCHAR(100),
								destinationLocation VARCHAR(100),
								shipmentDate DATETIME);
--Sensor Table--
CREATE TABLE vaccine.sensors( sensorId INT PRIMARY KEY, sensorType VARCHAR(50), sensorStatus VARCHAR(100), vibration DECIMAL(5,2),
                             shipmentId INT,
							 CONSTRAINT FK_sensor_shipment FOREIGN KEY (shipmentId) REFERENCES vaccine.shipments(shipmentId));

--Inventory Transactions Table--
CREATE TABLE vaccine.inventoryTransactions( inventoryId INT IDENTITY(1,1) PRIMARY KEY, quantityReceived INT, quantityUsed INT, transactionDate DATETIME,
                                           vaccineId INT,
										   CONSTRAINT FK_inventoryTransactions_vaccines FOREIGN KEY(vaccineId) REFERENCES vaccine.vaccines(vaccineId));

--Notifications Table --
CREATE TABLE vaccine.notifications(notificationId INT IDENTITY(1,1) PRIMARY KEY, notificationType VARCHAR(50),infoMessages VARCHAR(255),dateCreated DATETIME,
                                      vaccineId INT,
										   CONSTRAINT FK_notifications_vaccines FOREIGN KEY(vaccineId) REFERENCES vaccine.vaccines(vaccineId));  

--Insert Into User Table--
INSERT INTO vaccine.users(username,userPassword,email, userRole)
				   VALUES('amambomkhize@','@mamb02006','amambomkhize@gmail.com','Administrator'),
				         ('bongimanzi@','b0ng1m@nzi','bongimanzi@gmail.com','Driver Assistant'),
						 ('angyramathe','@ngyR@math#','angyramathe@gmail.com','Recipient');

		UPDATE vaccine.users
		SET userRole = 'Assistant'
		WHERE userRole = 'Driver Assistant';
		

--INSERT INTO Vaccine Table--
INSERT INTO vaccine.vaccines(vaccineName,manufacturer,batchNumber,expiryDate,minTemp,maxTemp,quantity)
                    VALUES ('Oral Polio Vaccine(OPV)','Panacea Biotech','MNCA','2030-10-13T12:07:00Z',-20,8,200 ),
					       ('HPV Vaccine','Merck & Co','YBVC','2030-10-13T12:07:00Z',2,8,400),
					       ('Pneumococcal Vaccine','Pfizer Inc.','WSZX','2030-10-13T12:07:00Z',2,8,260);

--INSERT INTO Shipment Table--
INSERT INTO vaccine.shipments(sourceLocation,destinationLocation,shipmentDate)
                     VALUES ('Panacea Biotech','Greenacres Hospital','2026-10-13T12:00:01Z'),
					        ('Merck & Co','Greenacres Hospital','2026-10-13T14:10:11Z'),
							('Pfizer Inc.','Greenacres Hospital','2026-10-13T15:31:34Z');

UPDATE vaccine.shipments SET vaccineId = 1  
WHERE shipmentId = 1;
UPDATE vaccine.shipments SET vaccineId = 2  
WHERE shipmentId = 2;
UPDATE vaccine.shipments SET vaccineId = 3  
WHERE shipmentId = 3;



--INSERT INTO Sensor Table--
INSERT INTO vaccine.sensors(sensorId,shipmentID,sensorType,sensorStatus,vibration)
                    VALUES( 8,1,'IC Sensors','Normal', 10),
					      ( 9,2,'Thermistors','Warning',55),
						  (10,3,'Resistive Humidity','Down',30);
						  

UPDATE vaccine.sensors SET vibration = 10
WHERE vibration = -10;
UPDATE vaccine.sensors SET vibration = 55
WHERE vibration = -45;
UPDATE vaccine.sensors SET vibration = 30
WHERE vibration = -20;


--INSERT INTO Inventory Transactions Table--
INSERT INTO vaccine.inventoryTransactions(vaccineId,quantityReceived,transactionDate)
                                   VALUES(1,200,'2026-09-12T09:00:00Z'),
								         (2,400, '2026-09-05T15:30:23Z'),
										 (3,260,'2026-09-07T12:00:20Z');

ALTER TABLE vaccine.inventoryTransactions
DROP COLUMN quantityUsed;



--INSERT INTO Notifications Table--
INSERT INTO vaccine.notifications(notificationType,infoMessages,dateCreated, vaccineId)
                           VALUES('Expiry Warning', 'PFZ001 is approaching expiry', '2026-09-27 14:00:00', 1),
							     ('Temperature Alert','Temperature Exceeded the safe range during shipment', '2026-10-01 12:00:00',2), 
					             ('Shipment Update',' AstraZeneca vaccine shipment is on the way','2026-10-03 14:00:00',3);

CREATE TABLE vaccine.orders(orderId INT IDENTITY(1,1) PRIMARY KEY,vaccineId INT, quantityOrdered INT,orderDate DATETIME, FOREIGN KEY (vaccineId) REFERENCES vaccine.vaccines(vaccineId))


INSERT INTO vaccine.orders(vaccineId,quantityOrdered,orderDate,shipmentId)
 VALUES(1,200,'2026-09-29T12:00:01Z',1),
	   (2,400,'2026-09-25T12:00:01Z',2),
	   (3,260,'2026-09-25T12:00:01Z',3);

 ALTER TABLE vaccine.orders
 ADD shipmentId INT;
 GO

ALTER TABLE vaccine.orders
ADD CONSTRAINT FK_vaccine_orders_vaccine_shipments FOREIGN KEY(shipmentId) REFERENCES vaccine.shipments(shipmentId);
	GO		;
	
	ALTER TABLE vaccine.users
ADD identityNumber VARCHAR(50) NULL;

CREATE UNIQUE INDEX UX_users_identityNumber
ON vaccine.users(identityNumber)
WHERE identityNumber IS NOT NULL;

UPDATE vaccine.users
SET identityNumber = CASE username
    WHEN 'amambomkhize@' THEN '1112014578962'
    WHEN 'bongimanzi@'   THEN '1102110236894'
    WHEN 'angyramathe'   THEN '1412112356468'
END
WHERE username IN ('amambomkhize@', 'bongimanzi@', 'angyramathe');

SELECT userId, username, identityNumber
FROM vaccine.users;



										 










































































































































































































































































































































