﻿CREATE PROC FI_SP_VerificarDuplicidadeCPF
	@CPF varchar(14)
AS
BEGIN
	SELECT 0 FROM CLIENTES WHERE CPF = @CPF
END