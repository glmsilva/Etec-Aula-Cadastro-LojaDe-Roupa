-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 07-Abr-2019 às 12:30
-- Versão do servidor: 10.1.38-MariaDB
-- versão do PHP: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_lojaroupa`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `cpf` char(11) DEFAULT NULL,
  `rg` char(9) DEFAULT NULL,
  `endereco` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`id`, `nome`, `cpf`, `rg`, `endereco`) VALUES
(3, 'Augusto Lucas Raul Sales', '05118585236', '277168806', 'Avenida Paraná, 382, Acrelandia, Acre'),
(4, 'Renato Elias Rodrigo Brito', '68489300321', '231209708', 'Travessa Michele,335, Fortaleza'),
(5, 'Raimunda Clara Vitória ', '04225056414', '486536555', 'Travessa Michele,335, Fortaleza'),
(6, 'Danilo João Daniel das Neves', '04225056414', '486536555', 'Passagem São Lázaro,Ananindeua, PA'),
(7, 'Clarice Laura Cristiane Figueiredo', '54616828806', '147297254', 'Jardim Santa Terezinha (Nova Veneza), Sumaré, SP');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `id` int(11) NOT NULL,
  `cpfFunc` char(11) NOT NULL,
  `nomeFunc` varchar(100) NOT NULL,
  `dsEndereco` varchar(255) DEFAULT NULL,
  `salario` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_funcionario`
--

INSERT INTO `tb_funcionario` (`id`, `cpfFunc`, `nomeFunc`, `dsEndereco`, `salario`) VALUES
(1, 'Teste', '12345678911', 'teste', 500),
(2, 'Teste', '12345678911', 'teste', 1500),
(3, 'Teste', '39484625851', 'teste', 1500),
(4, '39484625851', 'Teste', 'Teste', 1000),
(5, '39484625851', 'Teste', 'Teste', 1000),
(6, '05118585236', 'Clara Vitória', 'Passagem São Lázaro,Ananindeua, PA', 1000),
(7, '68489300321', 'Astolfo Ribeiro', 'Avenida Céu Azul,Ananindeua, PA', 1230.7),
(8, '54616828806', 'Betina Rudolf', 'Rua Empiricus,São Paulo, SP', 1420);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_login`
--

CREATE TABLE `tb_login` (
  `id` int(11) NOT NULL,
  `login` varchar(20) DEFAULT NULL,
  `senha` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_login`
--

INSERT INTO `tb_login` (`id`, `login`, `senha`) VALUES
(1, 'admin', '123456');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_loja`
--

CREATE TABLE `tb_loja` (
  `id` int(11) NOT NULL,
  `cnpj` char(14) DEFAULT NULL,
  `nomeLoja` varchar(100) DEFAULT NULL,
  `dsEndereco` varchar(255) DEFAULT NULL,
  `porte` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_loja`
--

INSERT INTO `tb_loja` (`id`, `cnpj`, `nomeLoja`, `dsEndereco`, `porte`) VALUES
(1, '1234567891011', 'Teste', 'Teste', 'Pequeno'),
(2, '11111111111111', 'Loja 2', 'RUa 2', 'Pequeno'),
(3, '90153010000150', 'Loja 3', 'Rua da Etec, 500, São Paulo', 'Médio');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_login`
--
ALTER TABLE `tb_login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_loja`
--
ALTER TABLE `tb_loja`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tb_login`
--
ALTER TABLE `tb_login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tb_loja`
--
ALTER TABLE `tb_loja`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
