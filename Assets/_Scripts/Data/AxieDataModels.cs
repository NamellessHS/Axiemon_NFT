using System;
using System.Collections.Generic;

namespace Axiemon.Data
{
    [Serializable]
    public class AxiePart
    {
        public string id;
        public string name;
        public string @class; // @ because 'class' is a reserved keyword in C#
        public string type;
        public string specialGenes;
    }

    [Serializable]
    public class Axie
    {
        public string id;
        public string name;
        public string image;
        public string @class;
        public List<AxiePart> parts;
    }

    [Serializable]
    public class AxieList
    {
        public int total;
        public List<Axie> results;
    }

    // Wrappers for JSON Parsing
    [Serializable]
    public class GraphQLResponse
    {
        public GraphQLData data;
    }

    [Serializable]
    public class GraphQLData
    {
        public AxieList axies;
    }
}
