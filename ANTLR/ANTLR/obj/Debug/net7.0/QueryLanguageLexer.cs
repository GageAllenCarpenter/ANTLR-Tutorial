﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\gagea\OneDrive\Desktop\ANTLR\ANTLR\QueryLanguage.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ANTLR {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class QueryLanguageLexer : Lexer {
	public const int
		T__0=1, T__1=2, WHITESPACE=3, STRING=4, SIGN=5, NUMBER=6;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "WHITESPACE", "STRING", "SIGN", "NUMBER"
	};


	public QueryLanguageLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'AND'", "'OR'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "WHITESPACE", "STRING", "SIGN", "NUMBER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "QueryLanguage.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\b\x39\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x3\x2\x3\x2"+
		"\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4\x6\x4\x18\n\x4\r\x4\xE\x4\x19\x3"+
		"\x4\x3\x4\x3\x5\x3\x5\a\x5 \n\x5\f\x5\xE\x5#\v\x5\x3\x5\x3\x5\x3\x6\x3"+
		"\x6\x3\a\x5\a*\n\a\x3\a\a\a-\n\a\f\a\xE\a\x30\v\a\x3\a\x5\a\x33\n\a\x3"+
		"\a\x6\a\x36\n\a\r\a\xE\a\x37\x3!\x2\x2\b\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2"+
		"\x6\v\x2\a\r\x2\b\x3\x2\x5\x5\x2\v\f\xF\xF\"\"\x4\x2--//\x3\x2\x32;>\x2"+
		"\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2"+
		"\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x3\xF\x3\x2\x2\x2\x5\x13\x3\x2\x2\x2\a"+
		"\x17\x3\x2\x2\x2\t\x1D\x3\x2\x2\x2\v&\x3\x2\x2\x2\r)\x3\x2\x2\x2\xF\x10"+
		"\a\x43\x2\x2\x10\x11\aP\x2\x2\x11\x12\a\x46\x2\x2\x12\x4\x3\x2\x2\x2\x13"+
		"\x14\aQ\x2\x2\x14\x15\aT\x2\x2\x15\x6\x3\x2\x2\x2\x16\x18\t\x2\x2\x2\x17"+
		"\x16\x3\x2\x2\x2\x18\x19\x3\x2\x2\x2\x19\x17\x3\x2\x2\x2\x19\x1A\x3\x2"+
		"\x2\x2\x1A\x1B\x3\x2\x2\x2\x1B\x1C\b\x4\x2\x2\x1C\b\x3\x2\x2\x2\x1D!\a"+
		"$\x2\x2\x1E \v\x2\x2\x2\x1F\x1E\x3\x2\x2\x2 #\x3\x2\x2\x2!\"\x3\x2\x2"+
		"\x2!\x1F\x3\x2\x2\x2\"$\x3\x2\x2\x2#!\x3\x2\x2\x2$%\a$\x2\x2%\n\x3\x2"+
		"\x2\x2&\'\t\x3\x2\x2\'\f\x3\x2\x2\x2(*\x5\v\x6\x2)(\x3\x2\x2\x2)*\x3\x2"+
		"\x2\x2*\x32\x3\x2\x2\x2+-\t\x4\x2\x2,+\x3\x2\x2\x2-\x30\x3\x2\x2\x2.,"+
		"\x3\x2\x2\x2./\x3\x2\x2\x2/\x31\x3\x2\x2\x2\x30.\x3\x2\x2\x2\x31\x33\a"+
		"\x30\x2\x2\x32.\x3\x2\x2\x2\x32\x33\x3\x2\x2\x2\x33\x35\x3\x2\x2\x2\x34"+
		"\x36\t\x4\x2\x2\x35\x34\x3\x2\x2\x2\x36\x37\x3\x2\x2\x2\x37\x35\x3\x2"+
		"\x2\x2\x37\x38\x3\x2\x2\x2\x38\xE\x3\x2\x2\x2\t\x2\x19!).\x32\x37\x3\b"+
		"\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ANTLR
