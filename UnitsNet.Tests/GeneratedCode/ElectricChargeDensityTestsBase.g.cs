﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricChargeDensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricChargeDensityTestsBase
    {
        protected abstract double CoulombsPerCubicMeterInOneCoulombPerCubicMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CoulombsPerCubicMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void CoulombPerCubicMeterToElectricChargeDensityUnits()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            AssertEx.EqualTolerance(CoulombsPerCubicMeterInOneCoulombPerCubicMeter, coulombpercubicmeter.CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricChargeDensity.From(1, ElectricChargeDensityUnit.CoulombPerCubicMeter).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
        }

        [Fact]
        public void As()
        {
            var coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            AssertEx.EqualTolerance(CoulombsPerCubicMeterInOneCoulombPerCubicMeter, coulombpercubicmeter.As(ElectricChargeDensityUnit.CoulombPerCubicMeter), CoulombsPerCubicMeterTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            AssertEx.EqualTolerance(1, ElectricChargeDensity.FromCoulombsPerCubicMeter(coulombpercubicmeter.CoulombsPerCubicMeter).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricChargeDensity v = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            AssertEx.EqualTolerance(-1, -v.CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricChargeDensity.FromCoulombsPerCubicMeter(3)-v).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricChargeDensity.FromCoulombsPerCubicMeter(10)/5).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, ElectricChargeDensity.FromCoulombsPerCubicMeter(10)/ElectricChargeDensity.FromCoulombsPerCubicMeter(5), CoulombsPerCubicMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricChargeDensity oneCoulombPerCubicMeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            ElectricChargeDensity twoCoulombsPerCubicMeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(2);

            Assert.True(oneCoulombPerCubicMeter < twoCoulombsPerCubicMeter);
            Assert.True(oneCoulombPerCubicMeter <= twoCoulombsPerCubicMeter);
            Assert.True(twoCoulombsPerCubicMeter > oneCoulombPerCubicMeter);
            Assert.True(twoCoulombsPerCubicMeter >= oneCoulombPerCubicMeter);

            Assert.False(oneCoulombPerCubicMeter > twoCoulombsPerCubicMeter);
            Assert.False(oneCoulombPerCubicMeter >= twoCoulombsPerCubicMeter);
            Assert.False(twoCoulombsPerCubicMeter < oneCoulombPerCubicMeter);
            Assert.False(twoCoulombsPerCubicMeter <= oneCoulombPerCubicMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.Equal(0, coulombpercubicmeter.CompareTo(coulombpercubicmeter));
            Assert.True(coulombpercubicmeter.CompareTo(ElectricChargeDensity.Zero) > 0);
            Assert.True(ElectricChargeDensity.Zero.CompareTo(coulombpercubicmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.Throws<ArgumentException>(() => coulombpercubicmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.Throws<ArgumentNullException>(() => coulombpercubicmeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ElectricChargeDensity a = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            ElectricChargeDensity b = ElectricChargeDensity.FromCoulombsPerCubicMeter(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ElectricChargeDensity v = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.True(v.Equals(ElectricChargeDensity.FromCoulombsPerCubicMeter(1), ElectricChargeDensity.FromCoulombsPerCubicMeter(CoulombsPerCubicMeterTolerance)));
            Assert.False(v.Equals(ElectricChargeDensity.Zero, ElectricChargeDensity.FromCoulombsPerCubicMeter(CoulombsPerCubicMeterTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.False(coulombpercubicmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.False(coulombpercubicmeter.Equals(null));
        }
    }
}
