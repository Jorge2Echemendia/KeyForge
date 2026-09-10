const express = require('express');
const cors = require('cors');
const app = express();
const PORT = 3000;

app.use(cors()); 

const productos = [
    {
        id: 1,
        nombre: "KeyForge Alpha",
        descripcion: "Teclado 60% con switches Cherry MX Red y chasis de aluminio CNC.",
        precio: 129.99,
        imagen: "https://images.unsplash.com/photo-1595225476474-87563907a212?auto=format&fit=crop&w=500&q=80",
        categoria: "Gaming",
        switches: "Cherry MX Red",
        layout: "60%"
    },
    {
        id: 2,
        nombre: "KeyForge Ergo",
        descripcion: "Diseño ergonómico dividido, switches silenciosos y keycaps PBT.",
        precio: 189.50,
        imagen: "https://images.unsplash.com/photo-1618384887929-16ec33fab9ef?auto=format&fit=crop&w=500&q=80",
        categoria: "Ergonómico",
        switches: "Cherry MX Silent",
        layout: "Split"
    },
    {
        id: 3,
        nombre: "KeyForge Pro",
        descripcion: "TKL profesional con macro keys y pantalla OLED integrada.",
        precio: 249.99,
        imagen: "https://images.unsplash.com/photo-1587829741301-dc798b83add3?auto=format&fit=crop&w=500&q=80",
        categoria: "Productividad",
        switches: "Cherry MX Brown",
        layout: "TKL"
    },
    {
        id: 4,
        nombre: "KeyForge Mini",
        descripcion: "Ultra compacto 40% perfecto para llevar a cualquier lado.",
        precio: 99.99,
        imagen: "https://www.pinterest.com/pin/527132331408805214/",
        categoria: "Compacto",
        switches: "Gateron Yellow",
        layout: "40%"
    },
    {
        id: 5,
        nombre: "KeyForge Studio",
        descripcion: "75% con perilla de volumen y teclas multimedia dedicadas.",
        precio: 169.99,
        imagen: "https://images.unsplash.com/photo-1511467687858-23d96c32e4ae?auto=format&fit=crop&w=500&q=80",
        categoria: "Productividad",
        switches: "Cherry MX Blue",
        layout: "75%"
    },
    {
        id: 6,
        nombre: "KeyForge RGB Elite",
        descripcion: "Full-size con iluminación RGB por tecla y reposamuñecas magnético.",
        precio: 199.99,
        imagen: "https://www.pinterest.com/pin/881790802011771703/",
        categoria: "Gaming",
        switches: "Cherry MX Red",
        layout: "Full-size"
    }
];

app.get('/api/productos', (req, res) => {
    res.json(productos);
});

app.listen(PORT, () => {
    console.log(`Servidor corriendo en http://localhost:${PORT}`);
});