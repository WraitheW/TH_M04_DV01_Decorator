using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PhoDecorators : iPho
{
    protected iPho m_TastierSoup;

    public PhoDecorators(iPho pho)
    {
        m_TastierSoup = pho;
    }

    public virtual float getRating()
    {
        return m_TastierSoup.getRating();
    }
}
public class withBeanSprouts : PhoDecorators
{
    float m_Rating = .5f;

    public withBeanSprouts(iPho pho) : base(pho) { }

    public override float getRating()
    {
        return base.getRating() + m_Rating;
    }
}

public class withCilantro : PhoDecorators
{
    float m_CilantroRating = 1f;

    public withCilantro(iPho pho) : base(pho) { }

    public override float getRating()
    {
        return base.getRating() + m_CilantroRating;
    }
}

public class withChiliPeppers : PhoDecorators
{
    private float m_ChiliRating = .75f;

    public withChiliPeppers(iPho pho) : base(pho) { }

    public override float getRating()
    {
        return base.getRating() + m_ChiliRating;
    }
}

public class withBasil : PhoDecorators
{
    private float m_BasilRating = .25f;

    public withBasil(iPho pho) : base(pho) { }

    public override float getRating()
    {
        return base.getRating() + m_BasilRating;
    }
}

public class withSqueezOfLime : PhoDecorators
{
    private float m_LimeRating = .5f;

    public withSqueezOfLime(iPho pho) : base(pho) { }

    public override float getRating()
    {
        return base.getRating() + m_LimeRating;
    }
}
