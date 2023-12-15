	CREATE VIEW VW_Livro_Cliente_Emprestimo
	AS
	select C.cliNome,L.livroNome, LCE.* from Livro_Cliente_Emprestimo LCE
	inner join Cliente C on C.id = LCE.lceIdCliente
	inner join Livro L on L.id = LCE.lceIdLivro

	SELECT * FROM VW_Livro_Cliente_Emprestimo