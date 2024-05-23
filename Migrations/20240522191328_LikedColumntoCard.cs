using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MTGApp.Migrations
{
    /// <inheritdoc />
    public partial class LikedColumntoCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "artists",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    full_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("artists_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "colors",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("colors_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "formats",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("formats_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "migrations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    migration = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    batch = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("migrations_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personal_access_tokens",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tokenable_type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    tokenable_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    token = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    abilities = table.Column<string>(type: "text", nullable: true),
                    last_used_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("personal_access_tokens_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rarities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("rarities_pkey", x => x.id);
                    table.UniqueConstraint("AK_rarities_code", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "sets",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("sets_pkey", x => x.id);
                    table.UniqueConstraint("AK_sets_code", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "types",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("types_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cards",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Liked = table.Column<bool>(type: "boolean", nullable: true),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    mana_cost = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    converted_mana_cost = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    rarity_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    set_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    text = table.Column<string>(type: "text", nullable: true),
                    flavor = table.Column<string>(type: "text", nullable: true),
                    artist_id = table.Column<long>(type: "bigint", nullable: true),
                    number = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    power = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    toughness = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    layout = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    multiverse_id = table.Column<int>(type: "integer", nullable: true),
                    original_image_url = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    image = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    original_text = table.Column<string>(type: "text", nullable: true),
                    original_type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    mtg_id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    variations = table.Column<string>(type: "json", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("cards_pkey", x => x.id);
                    table.ForeignKey(
                        name: "cards_artist_id_foreign",
                        column: x => x.artist_id,
                        principalTable: "artists",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "cards_rarity_code_foreign",
                        column: x => x.rarity_code,
                        principalTable: "rarities",
                        principalColumn: "code");
                    table.ForeignKey(
                        name: "cards_set_code_foreign",
                        column: x => x.set_code,
                        principalTable: "sets",
                        principalColumn: "code");
                });

            migrationBuilder.CreateTable(
                name: "card_colors",
                columns: table => new
                {
                    card_id = table.Column<long>(type: "bigint", nullable: false),
                    color_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("card_colors_pkey", x => new { x.card_id, x.color_id });
                    table.ForeignKey(
                        name: "card_colors_card_id_foreign",
                        column: x => x.card_id,
                        principalTable: "cards",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "card_colors_color_id_foreign",
                        column: x => x.color_id,
                        principalTable: "colors",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "card_types",
                columns: table => new
                {
                    card_id = table.Column<long>(type: "bigint", nullable: false),
                    type_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("card_types_pkey", x => new { x.card_id, x.type_id });
                    table.ForeignKey(
                        name: "card_types_card_id_foreign",
                        column: x => x.card_id,
                        principalTable: "cards",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "card_types_type_id_foreign",
                        column: x => x.type_id,
                        principalTable: "types",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_card_colors_color_id",
                table: "card_colors",
                column: "color_id");

            migrationBuilder.CreateIndex(
                name: "IX_card_types_type_id",
                table: "card_types",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_cards_artist_id",
                table: "cards",
                column: "artist_id");

            migrationBuilder.CreateIndex(
                name: "IX_cards_rarity_code",
                table: "cards",
                column: "rarity_code");

            migrationBuilder.CreateIndex(
                name: "IX_cards_set_code",
                table: "cards",
                column: "set_code");

            migrationBuilder.CreateIndex(
                name: "personal_access_tokens_token_unique",
                table: "personal_access_tokens",
                column: "token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "personal_access_tokens_tokenable_type_tokenable_id_index",
                table: "personal_access_tokens",
                columns: new[] { "tokenable_type", "tokenable_id" });

            migrationBuilder.CreateIndex(
                name: "rarities_code_unique",
                table: "rarities",
                column: "code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "sets_code_unique",
                table: "sets",
                column: "code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "card_colors");

            migrationBuilder.DropTable(
                name: "card_types");

            migrationBuilder.DropTable(
                name: "formats");

            migrationBuilder.DropTable(
                name: "migrations");

            migrationBuilder.DropTable(
                name: "personal_access_tokens");

            migrationBuilder.DropTable(
                name: "colors");

            migrationBuilder.DropTable(
                name: "cards");

            migrationBuilder.DropTable(
                name: "types");

            migrationBuilder.DropTable(
                name: "artists");

            migrationBuilder.DropTable(
                name: "rarities");

            migrationBuilder.DropTable(
                name: "sets");
        }
    }
}
