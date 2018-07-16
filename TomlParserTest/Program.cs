﻿using System;
using Toml;

namespace TomlParserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            OneTable("tests\\example.toml");
            OneTable("tests\\table-array-nest.toml");
            OneTable("tests\\table-array-many.toml");
            OneTable("tests\\table-array-one.toml");
            OneTable("tests\\table-array-implicit.toml");
            OneTable("tests\\table-with-pound.toml");
            OneTable("tests\\table-whitespace.toml");
            OneTable("tests\\table-sub-empty.toml");
            OneTable("tests\\table-empty.toml");
            OneTable("tests\\implicit-groups.toml");
            OneTable("tests\\implicit-and-explicit-before.toml");
            OneTable("tests\\implicit-and-explicit-after.toml");
            OneTable("tests\\key-special-chars.toml");
            OneTable("tests\\key-space.toml");
            OneTable("tests\\key-equals-nospace.toml");
            OneTable("tests\\empty.toml");
            OneTable("tests\\dottrd-keys.toml");
            OneTable("tests\\comments-everywhere.toml");
            OneTable("tests\\arrays-nested.toml");
            OneTable("tests\\arrays-hetergeneous.toml");
            OneTable("tests\\arrays.toml");
            OneTable("tests\\array-nospaces.toml");
            OneTable("tests\\array-empty.toml");
            OneTable("tests\\float_no_number.toml");
            OneTable("tests\\inline.toml");
            OneTable("tests\\unicode-escape.toml");
            OneTable("tests\\unicode-literal.toml");
            OneTable("tests\\bool.toml");
            OneTable("tests\\float.toml");
            OneTable("tests\\integer.toml");
            OneTable("tests\\long-float.toml");
            OneTable("tests\\long-integer.toml");
            OneTable("tests\\number-formated-decimal.toml");
            OneTable("tests\\datetime.toml");
            OneTable("tests\\raw-string.toml");
            OneTable("tests\\string-empty.toml");
            OneTable("tests\\string-escapes.toml");
            OneTable("tests\\string-simple.toml");
            OneTable("tests\\string-with-pound.toml");
            OneTable("tests\\raw-multiline-string.toml");
            OneTable("tests\\multiline-string.toml");

            OneTable("invalid\\array-mixed-types-arrays-and-ints.toml");
            OneTable("invalid\\array-mixed-types-ints-and-floats.toml");
            OneTable("invalid\\array-mixed-types-strings-and-ints.toml");
            OneTable("invalid\\datetime-malformed-no-leads.toml");
            OneTable("invalid\\datetime-malformed-no-secs.toml");
            OneTable("invalid\\datetime-malformed-no-t.toml");
            OneTable("invalid\\datetime-malformed-with-milli.toml");
            OneTable("invalid\\duplicate-keys.toml");
            OneTable("invalid\\duplicate-key-table.toml");
            OneTable("invalid\\duplicate-tables.toml");
            OneTable("invalid\\empty-implicit-table.toml");
            OneTable("invalid\\empty-table.toml");
            OneTable("invalid\\float-no-leading-zero.toml");
            OneTable("invalid\\float-no-trailing-digits.toml");
            OneTable("invalid\\key-empty.toml");
            OneTable("invalid\\key-hash.toml");
            OneTable("invalid\\key-newline.toml");
            OneTable("invalid\\key-open-bracket.toml");
            OneTable("invalid\\key-single-open-bracket.toml");
            OneTable("invalid\\key-space.toml");
            OneTable("invalid\\key-start-bracket.toml");
            OneTable("invalid\\key-two-equals.toml");
            OneTable("invalid\\multiline-string-err.toml");
            OneTable("invalid\\number_2_1_err.toml");
            OneTable("invalid\\number_2_err.toml");
            OneTable("invalid\\number_8_1_err.toml");
            OneTable("invalid\\number_8_err.toml");
            OneTable("invalid\\number_16_1_err.toml");
            OneTable("invalid\\number_16_err.toml");
            OneTable("invalid\\string-bad-byte-escape.toml");
            OneTable("invalid\\string-bad-escape.toml");
        }

        private static void OneTable(string path)
        {
            try {
                Console.WriteLine("---------- {0} ----------", path);
                var toml = new TomlDocument();
                toml.LoadPath(path);
                Console.WriteLine(toml);
            }
            catch (TomlAnalisysException e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
