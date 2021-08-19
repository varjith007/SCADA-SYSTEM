if exists 
(select name from sysobjects where name = 'GetMeasurementData'
AND  type = 'V')
drop view GetMeasurementData
go 


create view GetMeasurementData
as

select 
SENSOR.SensorId,
SENSOR.SensorName, 
MEASUREMENTDATA.MeasurementDataId,
MEASUREMENTDATA.MeasurementTimeStamp,
MEASUREMENTDATA.MeasurementValue,
MEASUREMENTDATA.FarenheitValue

From MEASUREMENTDATA 
inner join SENSOR on MEASUREMENTDATA.SensorId = SENSOR.SensorId

GO