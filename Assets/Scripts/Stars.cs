using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Stars : MonoBehaviour
{
    [SerializeField]
    private float m_stars;
    [SerializeField]
    private int m_numOfStars;

    [SerializeField]
    private Image[] m_starsImages;
    [SerializeField]
    private Sprite m_fullStar;
    [SerializeField]
    private Sprite m_halfStar;
    [SerializeField]
    private Sprite m_emptyStar;
    private Sprite Hello;

    private void Start()
    {
        for (int i = 0; i < m_numOfStars; ++i)
        {
            m_starsImages[i].enabled = true;
            if (i == m_stars - 0.5 && m_stars - (int)(m_stars) == 0.5)
            {
                m_starsImages[i].sprite = m_halfStar;
            }
            else if (i < m_stars)
            {
                m_starsImages[i].sprite = m_fullStar;
            }
            else
            {
                m_starsImages[i].sprite = m_emptyStar;
            }
        }

        for (int i = m_numOfStars; i < m_starsImages.Length; ++i)
        {
            m_starsImages[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}