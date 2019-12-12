// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const app = document.getElementById('root')
const container = document.createElement('div')
container.setAttribute('class', 'container')

app.appendChild(container)


fetch('https://localhost:44315/api/facts')
    .then(response => {
        return response.json()
    })
    .then(data => {
        var day = 1

        data.forEach(facts => {
            console.log(facts.description)
            const card = document.createElement('div')
            card.setAttribute('class', 'card')

            const p = document.createElement('p')
            facts.description = facts.description.substring(0, 300) // Limit to 300 chars
            p.textContent = day

            card.onclick = function () {
                
                p.textContent = `${facts.description}`
                card.appendChild(p)
            }
            //p.textContent = `${facts.description}...` // End with an ellipses

            container.appendChild(card)
            card.appendChild(p)
            day++
        })
    })
    .catch(err => {

    })


function showFact() {
    p.textContent = '${facts.description'
}

