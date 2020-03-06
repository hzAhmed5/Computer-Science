﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    [TestFixture]
    class UnitTests
    {
        [Test]
        public void AddFirstTest()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("First");
            Assert.That(list.First.Data, Is.EqualTo("First"));
            Assert.That(list.Last.Data, Is.EqualTo("First"));
        }

        [Test]
        public void AddLastTest()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("Last");
            Assert.That(list.Last.Data, Is.EqualTo("Last"));
        }

        [Test]
        public void SearchTest()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("First");
            list.AddAfter("First", new Node<string>("After 1"));
            list.AddAfter("After 1", new Node<string>("After 2"));
            Assert.That(list.SearchNode("After 1").Next.Data, Is.EqualTo("After 2"));
            Assert.That(list.SearchNode("After 2").Next.Data, Is.EqualTo("First"));
        }

        [Test]
        public void AddAfterTest()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("First");
            list.AddAfter(list.First.Data, new Node<string>("After 1"));
            list.AddAfter("After 1", new Node<string>("After 2"));
            Assert.That(list.SearchNode("After 1").Next.Data, Is.EqualTo("After 2"));
        }

        [Test]
        public void RemoveFirstTest()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("First");
            list.AddAfter(list.First.Data, new Node<string>("After 1"));
            list.AddAfter("After 1", new Node<string>("After 2"));
            list.RemoveFirst();
            Assert.That(list.First.Data, Is.EqualTo("After 1"));
            Assert.That(list.First.Next.Data, Is.EqualTo("After 2"));
        }
    }
}