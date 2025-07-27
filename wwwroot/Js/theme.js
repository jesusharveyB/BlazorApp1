window.cambiarTema = (tema) => {
    const body = document.body;

    // Limpiar clases anteriores
    body.classList.remove("dark", "red");

    // Agregar la nueva
    body.classList.add(tema);

    console.log("✅ Tema aplicado: " + tema);
};
