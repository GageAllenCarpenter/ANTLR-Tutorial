grammar QueryLanguage;
 
query
    : expression
    ;
 
expression
    : STRING                         #String
    | NUMBER                         #Number
    | expression 'AND' expression    #And
    | expression 'OR' expression     #Or
    ;
 
WHITESPACE  : (' '|'\t'|'\r'|'\n')+ -> skip; 
STRING : '"' .*? '"';
SIGN : ('+' | '-') ;
NUMBER : SIGN? ( [0-9]* '.' )? [0-9]+;