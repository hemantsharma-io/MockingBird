using Nustache.Core;
using Nustache.Compilation;
using System;
using System.IO;
using MockingBird.Domain;

namespace MockingBird.Core
{
    /// <summary>
    /// This class generates output from selected fiddler sessions
    /// </summary>
    public class CodeGenerator
    {
        private readonly Context _context;
        
        /// <summary>
        /// Create CodeGenratror instance
        /// </summary>
        /// <param name="sessions">Fiddler sessions as array</param>
        /// <param name="template">Mustache template</param>
        public CodeGenerator(Fiddler.Session[] sessions, string templateText)
        {
            _context = new Context(sessions, templateText);
        }

        /// <summary>
        /// Create compiled Nustache template
        /// </summary>
        /// <param name="templateText"></param>
        /// <returns>Compiled template as function</returns>
        private Func<Context, string> CreateCompiledTemplate(string templateText)
        {
            var codeTemplate = new Template();
            codeTemplate.Load(new StringReader(templateText));
            return codeTemplate.Compile<Context>(null);
        }

        /// <summary>
        /// Generates output for sessions in context and selected template
        /// </summary>
        /// <returns>Generated output</returns>
        public string GenerateOutput()
        {
            var compiledTemplate = CreateCompiledTemplate(_context.TempateText);
            return compiledTemplate(_context);
        }
    }
}
