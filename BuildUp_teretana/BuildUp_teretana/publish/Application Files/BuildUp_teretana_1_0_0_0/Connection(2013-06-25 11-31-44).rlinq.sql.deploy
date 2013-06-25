-- Generating stored procedure for OpenAccess
CREATE OR REPLACE FUNCTION "sp_oa_ins_Clan" ( Adresa_param varchar,  OUT AutoIncValue int4, Email_param varchar, Ime_param varchar, Kontakt_param varchar, Prezime_param varchar,  OUT RowsAffected int4, Spol_param varchar )  AS $$
BEGIN
INSERT INTO "Clan" ( "Adresa" , "Email" , "Ime" , "Kontakt" , "Prezime" , "Spol" ) VALUES ( Adresa_param , Email_param , Ime_param , Kontakt_param , Prezime_param , Spol_param )  ;
AutoIncValue = currval('"Clan_BrojIskaznice_seq"'); 
GET DIAGNOSTICS RowsAffected = ROW_COUNT;
END;
$$ LANGUAGE plpgsql;

;

