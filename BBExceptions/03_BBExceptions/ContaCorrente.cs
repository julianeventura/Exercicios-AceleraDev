﻿using System;

namespace _03_BBExceptions
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public static int ContadorSaquesNaoPermitidos { get; private set; }
        public static int ContadorTranferenciasNaoPermitidos { get; private set; }

        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("A agencia deve ser maior que 0", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("A agencia deve ser maior que 0", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido para saque", nameof(valor));
            }

            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(_saldo, valor);
                //return false;
            }

            _saldo -= valor;
            //return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            //if (_saldo < valor)
            //{
            //    return false;
            //}

            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido para transferência", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorTranferenciasNaoPermitidos++;
                throw new Exception ("Operação não realizada", e);
            }

            contaDestino.Depositar(valor);
            //return true;
        }
    }
}
