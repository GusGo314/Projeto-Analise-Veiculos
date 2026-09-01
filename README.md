Sistema de Análise de Estoque de Veículos

Sistema desktop desenvolvido em C# com Windows Forms para automatizar a análise de estoque de concessionárias de veículos.

O projeto nasceu de um processo real: analistas recebem planilhas Excel com dados de entrada de veículos e precisam cruzar manualmente essas informações com valores de mercado (tabela Fipe) para identificar discrepâncias de precificação. O sistema automatiza esse cruzamento, eliminando o trabalho manual em planilhas.

Funcionalidades
Importação de planilha Excel de estoque via seletor de arquivo
Visualização dos dados do estoque em tabela estruturada
Cruzamento automático de cada veículo com base de referência Fipe pelo número de placa
Cálculo da relação percentual entre o valor declarado na nota fiscal e o valor de mercado
Cálculo do valor total do estoque importado
Identificação de veículos não encontrados na base de referência
Observação sobre a integração Fipe

As APIs públicas de consulta Fipe são pagas. Por isso, a base de referência utilizada neste projeto é um mock local em JSON com 30 registros fictícios, estruturado para simular o retorno de uma consulta real por placa. A arquitetura do sistema permite substituir essa camada por uma integração real sem alterações no restante do código.

Tecnologias
C# / .NET 8
Windows Forms
ClosedXML (leitura de Excel)
System.Text.Json (leitura da base mock em JSON)

Como rodar
Clone o repositório
Abra o arquivo .sln no Visual Studio
Baixe o arquivo TestePlanilha no computador.
Execute o projeto com F5
Clique em "Carregar Planilha" e carregue o arquivo de testes.

(Visto que, inicialmente, o projeto serve para ler planilhas que vinham todas em um padrão especifico no ambiente de trabalho, leituras de planilhas com outras estruturas de dados e células podem causar erro)

Em desenvolvimento. Funcionalidades de análise avançada (filtros, exportação de relatório, resumo por marca) estão planejadas para próximas versões.
