namespace ParameterizedFactory
{
    public static class AnalisadorFactory
    {
        public static IFileParser Create(string fileName)
        {
            var extension = Path.GetExtension(fileName);
            return GetParser(extension);
        }

        private static IFileParser GetParser(string extension) => extension switch
        {
            ".json" => new JsonParser(),
            ".xml" => new XMlParser(),
            ".yaml" => new YamlParser(),
            _ => throw new InvalidParserTypeException("Extensão não implementada: (" + extension + ")")
        };
    }
}
