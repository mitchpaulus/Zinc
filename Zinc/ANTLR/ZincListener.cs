//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Zinc.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ZincParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IZincListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.grid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrid([NotNull] ZincParser.GridContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.grid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrid([NotNull] ZincParser.GridContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.gridMeta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGridMeta([NotNull] ZincParser.GridMetaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.gridMeta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGridMeta([NotNull] ZincParser.GridMetaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.ver"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVer([NotNull] ZincParser.VerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.ver"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVer([NotNull] ZincParser.VerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.tagsNoComma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTagsNoComma([NotNull] ZincParser.TagsNoCommaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.tagsNoComma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTagsNoComma([NotNull] ZincParser.TagsNoCommaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.tagsCommaOk"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTagsCommaOk([NotNull] ZincParser.TagsCommaOkContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.tagsCommaOk"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTagsCommaOk([NotNull] ZincParser.TagsCommaOkContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTag([NotNull] ZincParser.TagContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTag([NotNull] ZincParser.TagContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.tagMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTagMarker([NotNull] ZincParser.TagMarkerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.tagMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTagMarker([NotNull] ZincParser.TagMarkerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.tagPair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTagPair([NotNull] ZincParser.TagPairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.tagPair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTagPair([NotNull] ZincParser.TagPairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.cols"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCols([NotNull] ZincParser.ColsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.cols"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCols([NotNull] ZincParser.ColsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.col"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCol([NotNull] ZincParser.ColContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.col"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCol([NotNull] ZincParser.ColContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRow([NotNull] ZincParser.RowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRow([NotNull] ZincParser.RowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.val"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVal([NotNull] ZincParser.ValContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.val"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVal([NotNull] ZincParser.ValContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList([NotNull] ZincParser.ListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList([NotNull] ZincParser.ListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.dict"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDict([NotNull] ZincParser.DictContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.dict"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDict([NotNull] ZincParser.DictContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.nestedgrid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNestedgrid([NotNull] ZincParser.NestedgridContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.nestedgrid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNestedgrid([NotNull] ZincParser.NestedgridContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.scalar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScalar([NotNull] ZincParser.ScalarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.scalar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScalar([NotNull] ZincParser.ScalarContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZincParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool([NotNull] ZincParser.BoolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZincParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool([NotNull] ZincParser.BoolContext context);
}