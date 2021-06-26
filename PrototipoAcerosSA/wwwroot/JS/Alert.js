function confirmarEliminar(title, text, icon) {
    return new Promise(resolve => {
        Swal.fire({
            title,
            text,
            icon,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonText:'Cancelar',
            cancelButtonColor: '#d33',
            confirmButtonText: '¡Si, eliminar!'
        }).then((result) => {
            if (result.isConfirmed) {
                resolve(result.isConfirmed);
                Swal.fire({
                    icon: 'success',
                    title: '¡Eliminación exitosa!',
                    showConfirmButton: false,
                    timer: 2000
                })
            }
        })
    }) 
}
function confirmarGuardar(title,icon) {
    return new Promise(resolve => {
        Swal.fire({
            title,
            icon,
            showConfirmButton: false,
            timer: 2000
        }).then((result) => {
             resolve(result.isConfirmed);
        })
    })
}

function confirmarSalirPantalla(title, text, icon) {
    return new Promise(resolve => {
        Swal.fire({
            title,
            text,
            icon,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonText: 'Cancelar',
            cancelButtonColor: '#d33',
            confirmButtonText: '¡Salir!'
        }).then((result) => {
            resolve(result.isConfirmed);
        })
    })
}

function mensajeExito(title) {
    return new Promise(resolve => {
        Swal.fire({
            title,
            icon: 'success',
            showConfirmButton: false,
            timer: 2000
        }).then((result) => {
            resolve(result.isConfirmed);
        })
    })
}
