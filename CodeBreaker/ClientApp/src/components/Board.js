import React, {Component, useEffect, useRef} from "react";

let x = 0
const Board = () => {
    const canvasRef = useRef(null)

    useEffect(() => {
      
        const render = () => {
            const canvas = canvasRef.current
            const ctx = canvas.getContext('2d')

            ctx.clearRect(0, 0, canvas.width, canvas.height)
            ctx.beginPath()
            ctx.arc(x, 50, 20, 0, 2 * Math.PI)
            ctx.strokeStyle = 'black'
            ctx.strokeWidth = 4
            ctx.fill()
            ctx.stroke()
            x += 8
            console.log('circle creation');
            requestAnimationFrame(render)
        }
        
        render()
        
    }, [])

    return <canvas id="canvas" ref={canvasRef} height="500px" width={window.innerWidth - 20} />
}

export default Board