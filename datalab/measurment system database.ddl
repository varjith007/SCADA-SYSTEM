
CREATE TABLE SENSOR_TYPE
( 
	SensorTypeId         int  IDENTITY ( 1,1 )  NOT NULL ,
	SensorTypeName       varchar(50)  NULL ,
	PRIMARY KEY  CLUSTERED (SensorTypeId ASC)
)
go

CREATE TABLE SENSOR
( 
	SensorId             int  IDENTITY ( 1,1 )  NOT NULL ,
	SensorName           varchar(50)  NULL ,
	SensorTypeId         int  NULL ,
	PRIMARY KEY  CLUSTERED (SensorId ASC),
	 FOREIGN KEY (SensorTypeId) REFERENCES SENSOR_TYPE(SensorTypeId)
)
go

CREATE TABLE STATISTICSDATA
( 
	StatisticsDataId     int  IDENTITY ( 1,1 )  NOT NULL ,
	SensorId             int  NULL ,
	AverageData          float  NULL ,
	MinData              float  NULL ,
	MaxData              float  NULL ,
	PRIMARY KEY  CLUSTERED (StatisticsDataId ASC),
	 FOREIGN KEY (SensorId) REFERENCES SENSOR(SensorId)
)
go

CREATE TABLE MEASUREMENTDATA
( 
	MeasurementId        int  IDENTITY ( 1,1 )  NOT NULL ,
	SensorId             int  NULL ,
	MeasurementTimeStamp datetime  NULL ,
	MeasurementValue     float  NULL ,
	FarenheitValue       float  NULL ,
	PRIMARY KEY  CLUSTERED (MeasurementId ASC),
	 FOREIGN KEY (SensorId) REFERENCES SENSOR(SensorId)
)
go
