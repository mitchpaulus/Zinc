grammar Zinc;

options {
    language=CSharp;
}

grid : gridMeta cols row* ;

gridMeta : ver tagsNoComma '\n' ;

ver : 'ver:' STR ;

tagsNoComma : tag* ;

tagsCommaOk: (tag ','?)* ;

tag        :  tagMarker | tagPair ;
tagMarker  :  ID ; // val is assumed to be Marker
tagPair    :  ID ':' val ;
cols       :  col (',' col)* '\n' ;
col        :  ID tagsNoComma ;
row        :  NULL  '\n' | val (',' val?)* '\n' ;
val        :  scalar | list | dict | nestedgrid ;
list       : '[' ']' |  '[' val (',' val)* ','? ']'  ; // trailing comma allowed/optional
dict       :  '{' tagsCommaOk '}' ;
nestedgrid   :  '<<' '\n'? grid '>>' ;

ID : ALPHALO ( ALPHA | DIGIT | '_' )* ;

scalar : NULL | MARKER | REMOVE | NA | bool | REF | SYMBOL | STR | URI | NUMBER | DATE | TIME | DATETIME | COORD | XSTR;

bool : TRUE | FALSE ;

NA     : 'NA';
NULL   : 'N';
MARKER : 'M';
REMOVE : 'R';
TRUE   : 'T';
FALSE  : 'F';

COORD : 'C(' COORDDEG ',' COORDDEG ')' ;
fragment COORDDEG : '-'? DIGITS ('.' DIGITS)? ;

XSTR : XSTRTYPE '(' STR ')' ;
fragment XSTRTYPE : ALPHAHI (ALPHA | DIGIT | '_')* ;

SYMBOL : '^' REFCHAR+;
REF : '@' REFCHAR+ (' ' STR)?;

// See page. 78 Definitive ANTLR Reference
STR : '"' (ESC | .)*? '"' ;
URI : '`' (ESC | .)*? '`' ;

NUMBER : DECIMAL | 'INF' | '-INF' | 'NaN' ;
fragment DECIMAL : '-'? DIGITS ('.' DIGITS)? EXP? UNIT? ;
fragment EXP     : ('e'|'E') ('+'|'-')? DIGITS ;
fragment UNIT    : UNITCHAR* ;
fragment UNITCHAR : ALPHA | '%' | '_' | '/' | '$' ;

DATE : DIGIT DIGIT DIGIT DIGIT '-' DIGIT DIGIT '-' DIGIT DIGIT ;

TIME : DIGIT DIGIT ':' DIGIT DIGIT (':' DIGIT DIGIT ('.' DIGIT+)?  )? ;

DATETIME : DATE 'T' TIME 'Z'? (ALPHA+)? ;

fragment ESC : '\\"' | '\\\\' ;

fragment REFCHAR : ALPHA | DIGIT | '_' | ':' | '-' | '.' | '~' ;

fragment ALPHALO : [a-z];
fragment ALPHAHI : [A-Z];
fragment DIGIT : [0-9];
fragment DIGITS : DIGIT (DIGIT | '_')* ;

fragment ALPHA : ALPHALO | ALPHAHI;

WS : ' '+ -> skip ;

