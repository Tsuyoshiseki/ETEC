-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 15, 2025 at 08:25 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wigla_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `siglas`
--

CREATE TABLE `siglas` (
  `id` int(11) NOT NULL,
  `sigla` varchar(20) NOT NULL,
  `significado` varchar(50) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `categoria` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `siglas`
--

INSERT INTO `siglas` (`id`, `sigla`, `significado`, `descricao`, `categoria`) VALUES
(1, 'teste', 'teste', 'testres', 'Desenvolvimento e Infraestrutura'),
(2, 'TI', 'Tecnologia da Informação', 'ti', 'Gestão e Negócios'),
(4, 'HTTP', 'HyperText Transfer Protocol', 'Protocolo usado para comunicação entre navegadores e servidores web.', 'Desenvolvimento e Infraestrutura'),
(5, 'SQL', 'Structured Query Language', 'Linguagem padrão para gerenciamento de bancos de dados relacionais.', 'Desenvolvimento e Infraestrutura'),
(6, 'API', 'Application Programming Interface', 'Conjunto de rotinas e padrões usados para integração entre sistemas.', 'Desenvolvimento e Infraestrutura'),
(7, 'JSON', 'JavaScript Object Notation', 'Formato leve de troca de dados, muito usado em APIs.', 'Desenvolvimento e Infraestrutura'),
(8, 'DBMS', 'Database Management System', 'Sistema de gerenciamento de bancos de dados.', 'Desenvolvimento e Infraestrutura'),
(10, 'IP', 'Internet Protocol', 'Protocolo que define o endereçamento e roteamento de pacotes na Internet.', 'Desenvolvimento e Infraestrutura'),
(11, 'RAM', 'Random Access Memory', 'Memória de acesso aleatório usada para armazenar dados temporários.', 'Desenvolvimento e Infraestrutura'),
(12, 'CPU', 'Central Processing Unit', 'Unidade central de processamento responsável pela execução de instruções.', 'Desenvolvimento e Infraestrutura'),
(13, 'UI', 'User Interface', 'Parte visual de um sistema com a qual o usuário interage.', 'Experiência do Usuário'),
(14, 'UX', 'User Experience', 'Experiência total que um usuário tem ao utilizar um produto ou sistema.', 'Experiência do Usuário'),
(15, 'CSS', 'Cascading Style Sheets', 'Linguagem usada para definir o estilo visual de páginas web.', 'Experiência do Usuário'),
(16, 'HTML', 'HyperText Markup Language', 'Linguagem base para estruturação de páginas web.', 'Experiência do Usuário'),
(17, 'OOP', 'Object-Oriented Programming', 'Paradigma de programação baseado em objetos e classes.', 'Desenvolvimento e Infraestrutura'),
(18, 'IDE', 'Integrated Development Environment', 'Ambiente de desenvolvimento com editor, depurador e compilador integrados.', 'Desenvolvimento e Infraestrutura'),
(19, 'CRUD', 'Create, Read, Update, Delete', 'Operações básicas de manipulação de dados em um banco.', 'Desenvolvimento e Infraestrutura'),
(20, 'MVC', 'Model-View-Controller', 'Padrão de arquitetura de software que separa lógica, interface e controle.', 'Desenvolvimento e Infraestrutura'),
(22, 'AI', 'Artificial Intelligence', 'Campo da computação que cria sistemas capazes de aprender e tomar decisões.', 'Gestão e Negócios'),
(23, 'IoT', 'Internet of Things', 'Rede de objetos físicos conectados que coletam e trocam dados.', 'Gerenciamento e Operação'),
(24, 'B2B', 'Business to Business', 'Modelo de negócio entre empresas.', 'Gestão e Negócios'),
(25, 'KPI', 'Key Performance Indicator', 'Indicador usado para medir desempenho.', 'Gestão e Negócios'),
(26, 'ROI', 'Return on Investment', 'Métrica de retorno sobre investimento.', 'Gestão e Negócios'),
(27, 'API', 'Application Programming Interface', 'Interface que permite a comunicação entre sistemas.', 'Desenvolvimento e Infraestrutura'),
(28, 'DNS', 'Domain Name System', 'Sistema de nomes de domínio da internet.', 'Desenvolvimento e Infraestrutura'),
(29, 'CI/CD', 'Continuous Integration / Continuous Delivery', 'Práticas para automação de desenvolvimento e entrega de software.', 'Desenvolvimento e Infraestrutura'),
(30, 'VPN', 'Virtual Private Network', 'Rede privada virtual para conexões seguras.', 'Segurança e Acesso'),
(31, 'SSL', 'Secure Sockets Layer', 'Protocolo para proteger conexões web.', 'Segurança e Acesso'),
(32, 'MFA', 'Multi-Factor Authentication', 'Autenticação com múltiplos fatores.', 'Segurança e Acesso'),
(33, 'ITIL', 'Information Technology Infrastructure Library', 'Conjunto de boas práticas para gestão de TI.', 'Gerenciamento e Operação'),
(34, 'SLA', 'Service Level Agreement', 'Acordo de nível de serviço entre provedor e cliente.', 'Gerenciamento e Operação'),
(35, 'CMDB', 'Configuration Management Database', 'Banco de dados de gerenciamento de configuração.', 'Gerenciamento e Operação'),
(36, 'UX', 'User Experience', 'Experiência do usuário ao interagir com um produto ou sistema.', 'Experiência do Usuário'),
(37, 'UI', 'User Interface', 'Interface gráfica do usuário.', 'Experiência do Usuário'),
(38, 'A/B', 'A/B Testing', 'Teste comparativo entre duas versões de uma interface.', 'Experiência do Usuário'),
(39, 'USB', 'Universal Serial Bus', 'É um padrão da indústria que estabelece especificações para cabos, conectores e protocolos para conexão, comunicação e alimentação entre computadores, periféricos e outros computadores.', 'Desenvolvimento e Infraestrutura');

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `senha` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `email`, `senha`) VALUES
(1, 'Admin', 'admin', '123'),
(2, 'Luã Seki', 'tsuyoshiseki@hotmail.com', '123'),
(3, 'Leticia Karine dos Santos', 'leticiakarin3@gmail.com', 'ludalele');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `siglas`
--
ALTER TABLE `siglas`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `siglas`
--
ALTER TABLE `siglas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
