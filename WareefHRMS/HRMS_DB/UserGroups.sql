﻿CREATE TABLE UserGroups (
            UGID int IDENTITY(1,1) PRIMARY KEY,
			NAME varchar(255),
			Last_updated_by int,
			Last_updated_date date,
			Obsoleted boolean

);