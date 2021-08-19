 IF EXISTS (SELECT name
 from sysobjects
 WHERE name = 'SaveMeasurementData'
 AND type = 'P')
DROP PROCEDURE SaveMeasurementData
 GO 


 CREATE PROCEDURE SaveMeasurementData
 @SensorName varchar(50),
 @MeasurementValue  float

 AS 

 DECLARE 
 @SensorId int 

 Select @SensorId = SensorId from SENSOR where SensorName = @SensorName

 Insert into MEASUREMENTDATA (SensorId, MeasurementValue, MeasurementTimestamp) Values (@SensorId,@MeasurementValue, getdate())

 GO
