USE [Premier_Service_Solutions]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [BackupChanges]
	 ON DATABASE
	 FOR CREATE_PROCEDURE, ALTER_PROCEDURE, DROP_PROCEDURE,CREATE_TABLE, ALTER_TABLE, DROP_TABLE,CREATE_FUNCTION, ALTER_FUNCTION, DROP_FUNCTION,CREATE_VIEW,ALTER_VIEW,DROP_VIEW
			AS
 
			SET NOCOUNT ON
 
			DECLARE @data XML
			SET @data = EVENTDATA()
 
			INSERT INTO CHANGELOG(databasename, eventtype, 
				objectname, objecttype, sqlcommand, loginname)
			VALUES(
			@data.value('(/EVENT_INSTANCE/DatabaseName)[1]', 'varchar(256)'),
			@data.value('(/EVENT_INSTANCE/EventType)[1]', 'varchar(50)'), 
			@data.value('(/EVENT_INSTANCE/ObjectName)[1]', 'varchar(256)'), 
			@data.value('(/EVENT_INSTANCE/ObjectType)[1]', 'varchar(25)'), 
			@data.value('(/EVENT_INSTANCE/TSQLCommand)[1]', 'varchar(max)'), 
			@data.value('(/EVENT_INSTANCE/LoginName)[1]', 'varchar(256)')
			);

	ENABLE TRIGGER BackupChanges ON DATABASE
GO

ENABLE TRIGGER [BackupChanges] ON DATABASE
GO