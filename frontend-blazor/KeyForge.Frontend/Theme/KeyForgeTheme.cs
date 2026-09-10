using MudBlazor;

namespace KeyForge.Frontend.Theme
{
    public static class KeyForgeTheme
    {
        public static MudTheme GetTheme() => new MudTheme()
        {
            // 🌞 MODO CLARO PROFESIONAL (Estilo WrapPixel/Admin Templates)
            PaletteLight = new PaletteLight()
            {
                // Colores primarios - Indigo profesional
                Primary = "#556cd6",           // Azul índigo profesional
                Secondary = "#5f6575",         // Gris azulado
                Tertiary = "#ff5722",          // Naranja para acentos
                
                // Fondos - NO blanco puro
                AppbarBackground = "#ffffff",
                Background = "#f4f6f8",        // Gris muy claro (como WrapPixel)
                Surface = "#ffffff",           // Blanco solo para cards
                DrawerBackground = "#ffffff",
                
                // Textos
                TextPrimary = "#212529",       // Casi negro
                TextSecondary = "#5f6575",     // Gris medio
                DrawerText = "#212529",
                
                // Acciones y estados
                ActionDefault = "#5f6575",
                ActionDisabled = "#aeb0b4",
                ActionDisabledBackground = "rgba(0,0,0,0.12)",
                
                // Colores semánticos
                Dark = "#343a40",
                Info = "#03a9f4",
                Success = "#11c167",           // Verde esmeralda
                Warning = "#ffbc34",           // Amarillo dorado
                Error = "#fb6340",             // Rojo coral
                
                // Bordes y divisores
                Divider = "#e8eaec",           // Gris muy suave
                LinesDefault = "#e8eaec",
                
                // Overlay
                OverlayDark = "rgba(0,0,0,0.5)"
            },
            
            // 🌙 MODO OSCURO (Mantenemos el anterior pero mejorado)
            PaletteDark = new PaletteDark()
            {
                Primary = "#7c4dff",
                Secondary = "#26c6da",
                Tertiary = "#ff5722",
                AppbarBackground = "#1a1f2e",
                Background = "#151922",        // Azul muy oscuro
                Surface = "#1e252f",           // Gris azulado oscuro
                DrawerBackground = "#1a1f2e",
                DrawerText = "#a0aec0",
                TextPrimary = "#ffffff",
                TextSecondary = "#a0aec0",
                Dark = "#0f1419",
                Info = "#03a9f4",
                Success = "#11c167",
                Warning = "#ffbc34",
                Error = "#fb6340",
                Divider = "#2d3748",
                LinesDefault = "#2d3748",
                OverlayDark = "rgba(0,0,0,0.7)"
            },
            
            // Layout
            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "8px",
                AppbarHeight = "64px"
            },
            
            // Tipografía
            Typography = new Typography()
            {
                Default = new DefaultTypography()
                {
                    FontFamily = new[] { "Inter", "Roboto", "Helvetica", "Arial", "sans-serif" },
                    FontSize = ".875rem",
                    FontWeight = "400",
                    LineHeight = "1.5",
                    LetterSpacing = "normal",
                    TextTransform = "none"
                },
                H1 = new H1Typography() { FontSize = "2.5rem", FontWeight = "600" },
                H2 = new H2Typography() { FontSize = "2rem", FontWeight = "600" },
                H3 = new H3Typography() { FontSize = "1.75rem", FontWeight = "600" },
                H4 = new H4Typography() { FontSize = "1.5rem", FontWeight = "600" },
                H5 = new H5Typography() { FontSize = "1.25rem", FontWeight = "600" },
                H6 = new H6Typography() { FontSize = "1rem", FontWeight = "600" },
                Subtitle1 = new Subtitle1Typography() { FontSize = "1rem", FontWeight = "500" },
                Subtitle2 = new Subtitle2Typography() { FontSize = ".875rem", FontWeight = "500" },
                Body1 = new Body1Typography() { FontSize = "1rem", FontWeight = "400" },
                Body2 = new Body2Typography() { FontSize = ".875rem", FontWeight = "400" }
            },
            
            // Sombras mejoradas
            Shadows = new Shadow()
            {
                Elevation = new string[]
                {
                    "none",
                    "0 2px 4px rgba(145, 158, 171, 0.12)",
                    "0 4px 8px rgba(145, 158, 171, 0.16)",
                    "0 8px 16px rgba(145, 158, 171, 0.2)",
                    "0 12px 24px rgba(145, 158, 171, 0.24)",
                    "0 16px 32px rgba(145, 158, 171, 0.28)"
                }
            }
        };
    }
}