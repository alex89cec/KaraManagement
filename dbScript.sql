CREATE DATABASE karamanagement
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    CONNECTION LIMIT = -1;

GO

CREATE SCHEMA db
    AUTHORIZATION postgres;

GO
CREATE TABLE db.students
(
    "Dni" integer NOT NULL,
    "Nombre " text COLLATE pg_catalog."default" NOT NULL,
    "Apellido" text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT students_pkey PRIMARY KEY ("Dni")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE db.students
    OWNER to postgres;

GO